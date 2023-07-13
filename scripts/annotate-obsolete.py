from __future__ import division, print_function

import argparse
import re

SUMMARY_START_RE = re.compile(r"^(?P<indent>\s*)///\s+<summary>$")
COMMENT_RE = re.compile(r"^\s*///")
DEPRECATED_RE = re.compile(r"^\s*///\s+DEPRECATED:\s*(?P<message>.+)$")


def main(input_file):
    filename = input_file.name
    content = [line.rstrip() for line in input_file.readlines()]
    input_file.close()

    with open(filename, "wt") as result:
        indent = None  # keeps state, if None nothing to write
        obsolete_message = None

        for line in content:
            deprecated_match = DEPRECATED_RE.match(line)
            if indent is not None and deprecated_match:
                # deprecation message found
                obsolete_message = f"{indent}[Obsolete(\"{deprecated_match.groupdict()['message']}\", false)]"

            if indent is not None and not COMMENT_RE.match(line):
                # comment section ended
                indent = None
                if obsolete_message:
                    if not line.lstrip().startswith("[Obsolete"):
                        result.write(obsolete_message + "\n")
                    obsolete_message = None

                    result.write(line + "\n")
                    continue

            match = SUMMARY_START_RE.match(line)
            if match:
                # comment section started
                indent = match.groupdict()["indent"]

            result.write(line + "\n")


def parse_args():
    parser = argparse.ArgumentParser()
    parser.add_argument("input_file", type=argparse.FileType("rt"))
    args = parser.parse_args()
    return vars(args)


if __name__ == "__main__":
    main(**parse_args())
