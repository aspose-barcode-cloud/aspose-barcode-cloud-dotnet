.PHONY: all
all: test

.PHONY: init
init:
	dotnet tool install --global dotnet-format

.PHONY: format
format:
	dotnet restore ./Aspose.BarCode.Cloud.Sdk.sln
	dotnet format ./Aspose.BarCode.Cloud.Sdk.sln --no-restore
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
	./scripts/annotate-obsolete.bash

.PHONY: update
update:
	echo "Not implemented"

.PHONY: lint
lint:
	dotnet build --warnaserror Aspose.BarCode.Cloud.Sdk.sln
	dotnet build --warnaserror examples/examples.sln

.PHONY: clean
clean:
	find . -depth -type d \( -name obj -o -name bin -o -name TestResults \) -exec rm -rf "{}" \; || true

.PHONY: nuget
nuget:
	./scripts/pack-nuget.bash
	./scripts/test-nuget.bash
