.PHONY: all
all: test

.PHONY: format
format:
	dotnet format

.PHONY: test
test:
	dotnet test

.PHONY: update
update:
	echo "Not implemented"
