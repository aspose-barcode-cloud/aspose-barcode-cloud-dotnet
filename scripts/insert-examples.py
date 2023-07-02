from __future__ import division, print_function

import argparse
import os
import typing


def read_text(filename: str) -> str:
    with open(filename, "rt") as rf:
        text = rf.read()
    return text


def save_text(writable_f: typing.TextIO, text: str) -> None:
    writable_f.write(text.replace("\r", ""))


def format_text(text: str, **kwargs) -> str:
    for k, v in kwargs.items():
        to_replace = "%{0}%".format(k)
        text = text.replace(to_replace, v)
    return text


def main(template: typing.TextIO, destination: typing.TextIO) -> None:
    generate_qr_example = read_text(os.path.join("examples", "GenerateQR", "Program.cs"))
    read_qr_example = read_text(os.path.join("examples", "ReadQR", "Program.cs"))

    text = template.read()
    formatted = format_text(text, GenerateQRExample=generate_qr_example, ReadQRExample=read_qr_example)
    save_text(destination, formatted)


def parse_args() -> typing.Dict[str, typing.Any]:
    parser = argparse.ArgumentParser()
    parser.add_argument("template", type=argparse.FileType("rt"))
    parser.add_argument("destination", type=argparse.FileType("wt"))
    kwargs = vars(parser.parse_args())
    return kwargs


if __name__ == "__main__":
    main(**parse_args())
