import re
import subprocess
import os
import sys
import fileinput
import collections

URL_REGEX = re.compile(r"""(http[s]*://[^{})"'<>#\s]+)[)"'<>#\s]""")

GOOD_URLS = set('https://www.aspose.cloud',)
BROKEN_URLS = collections.defaultdict(list)


def check_url(url):
    with open(os.devnull, 'w') as devnull:
        ret_code = subprocess.call(['curl', '-sSf', '--user-agent', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:91.0) Gecko/20100101 Firefox/91.0', url], stdout=devnull)
    return ret_code == 0


def check_file(filename):
    with open(filename, 'r') as f:
        urls = frozenset(URL_REGEX.findall(f.read()))

    for url in sorted(urls):
        if url in GOOD_URLS:
            continue
        elif url in BROKEN_URLS:
            continue

        if check_url(url):
            print("OK: '%s'" % url)
            GOOD_URLS.add(url)
        else:
            print("BROKEN: '%s' in file %s" % (url, filename))
            BROKEN_URLS[url].append(filename)


def main():
    for filename in fileinput.input():
        check_file(filename.strip())

    for url, files in BROKEN_URLS.items():
        print("BROKEN URL: '%s' in files: %s" % (url, ', '.join(files)), file=sys.stderr)
    if BROKEN_URLS:
        exit(1)


if __name__ == '__main__':
    main()
