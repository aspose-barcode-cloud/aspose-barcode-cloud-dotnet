from __future__ import division, print_function

import re
import subprocess
import os
import sys
import fileinput
import collections

URL_END_CHARS = r")\"'<>#\*\s\\"
URL_REGEX = re.compile(r"(http[s]*://[^{%s}]+)[%s]" % (URL_END_CHARS, URL_END_CHARS))

GOOD_URLS = set([
    'http://localhost:12345',
    'http://localhost:12345/v3.0',
    'http://some',
    'https://api.aspose.cloud/connect/token',
    'https://api.aspose.cloud/v3.0',
    'https://products.aspose.cloud/barcode/',
    'https://www.aspose.cloud',
    'https://blog.aspose.cloud/categories/aspose.barcode-cloud-product-family/',
])
BROKEN_URLS = collections.defaultdict(list)


def check_url(url):
    with open(os.devnull, 'w') as devnull:
        ret_code = subprocess.call(['curl', '-sSf', '--output', '-', '--user-agent', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:91.0) Gecko/20100101 Firefox/91.0', url], stdout=devnull)
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
