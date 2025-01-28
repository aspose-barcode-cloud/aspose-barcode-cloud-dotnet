LATEST_SDK_VERSION=$(shell dotnet --list-sdks | awk -F. '{print $$1 "." $$2}' | sort -n | tail -n 1)

.PHONY: all
all: test

.PHONY: init
init:
	dotnet tool install --global dotnet-format

.PHONY: format
format:
	dotnet restore ./Aspose.BarCode.Cloud.Sdk.sln
	dotnet format ./Aspose.BarCode.Cloud.Sdk.sln --no-restore
	dotnet format --include ./snippets/
	# Trim white space in comments
	find . -iname "*.cs" -exec sed -i -e 's_[[:space:]]*$$__' {} \;


.PHONY: format-doc
format-doc:
	# Remove trailing white space
	find . -iname "*.md" -exec sed -i -e 's_[[:space:]]*$$__' {} \;

.PHONY: test
test:
	dotnet test -v normal --framework=net$(LATEST_SDK_VERSION)
	./scripts/run_snippests.sh

.PHONY: build
build:
	dotnet build -v normal --framework=net$(LATEST_SDK_VERSION)

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
	dotnet build --warnaserror Aspose.BarCode.Cloud.Sdk.sln --framework=net$(LATEST_SDK_VERSION)

.PHONY: clean
clean:
	find . -depth -type d \( -name obj -o -name bin -o -name TestResults \) -exec rm -rf "{}" \; || true

.PHONY: nuget
nuget:
	./scripts/pack-nuget.bash
	./scripts/test-nuget.bash
