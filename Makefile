.PHONY: all
all: test

.PHONY: format
format:
	find . -iname "*.cs" -exec sed -i -e 's_[[:space:]]*$$__' {} \;
	~/.dotnet/tools/dotnet-format ./Aspose.BarCode.Cloud.Sdk.sln

.PHONY: format-doc
format-doc:
	find . -iname "*.md" -exec sed -i -e 's_[[:space:]]*$$__' {} \;

.PHONY: test
test:
	dotnet test

.PHONY: update
update:
	echo "Not implemented"

.PHONY: insert-examples
insert-examples:
	./scripts/insert-examples.bash

.PHONY: after-gen
after-gen: insert-examples format format-doc
