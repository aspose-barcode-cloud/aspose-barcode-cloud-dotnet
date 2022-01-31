from __future__ import division, print_function

import argparse
import os


def read_text(filename):
    with open(filename, 'rt') as rf:
        text = rf.read()
    return text.decode('utf-8')


def save_text(fobj, text):
    fobj.write(text.replace('\r', ''))


def format_text(text, **kwargs):
    for k, v in kwargs.items():
        to_replace = '%{0}%'.format(k)
        text = text.replace(to_replace, v)
    return text


def main(template, destination):
    generate_qr_example = read_text(os.path.join("examples", "GenerateQR", "Program.cs"))
    read_qr_example = read_text(os.path.join("examples", "ReadQR", "Program.cs"))

    text = template.read()
    formatted = format_text(text, GenerateQRExample=generate_qr_example, ReadQRExample=read_qr_example)
    save_text(destination, formatted)


def parse_args():
    parser = argparse.ArgumentParser()
    parser.add_argument('template', type=argparse.FileType('rt'))
    parser.add_argument('destination', type=argparse.FileType('wt'))
    kwargs = vars(parser.parse_args())
    return kwargs


if __name__ == '__main__':
    main(**parse_args())
