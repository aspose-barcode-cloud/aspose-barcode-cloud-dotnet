.PHONY: all
all: test

.PHONY: init
init:
	dotnet tool install --global dotnet-format

.PHONY: format
format:
	~/.dotnet/tools/dotnet-format ./Aspose.BarCode.Cloud.Sdk.sln
	# Trim white space in comments
	find . -iname "*.cs" -exec sed -i -e 's_[[:space:]]*$$__' {} \;

.PHONY: format-doc
format-doc:
	find . -iname "*.md" -exec sed -i -e 's_[[:space:]]*$$__' {} \;

.PHONY: test
test:
	dotnet test

.PHONY: insert-examples
insert-examples:
	./scripts/insert-examples.bash

.PHONY: after-gen
after-gen: insert-examples format format-doc

.PHONY: update
update:
	echo "Not implemented"

.PHONY: clean
clean:
	find . -depth -type d \( -name obj -o -name bin -o -name TestResults \) -exec rm -rf "{}" \; || true
