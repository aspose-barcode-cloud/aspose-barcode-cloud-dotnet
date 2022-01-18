.PHONY: all
all: test

.PHONY: format
format:
	dotnet format ./Aspose.BarCode.Cloud.Sdk.sln

.PHONY: test
test:
	dotnet test

.PHONY: update
update:
	echo "Not implemented"
