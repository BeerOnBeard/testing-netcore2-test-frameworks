# Testing NetCore 2.0 Testing Frameworks in C#

I wanted to see what it was like to develop on .NET Core 2 using Visual Studio Code. The business project represents a business layer that I would want to test. I set up two different test projects. One project uses Machine.Specifications. The other project uses XUnit.

One "gotcha" I ran into while trying to get this to work: the test projects must target `netcoreapp` instead of `netstandard`. The XUnit and Machine.Specification dependencies are relying on that target framework. When I targeted `netstandard2.0`, nothing would happen. Once I switched to `netcoreapp2.0`, the tests were recognized and I was in business.

## Prerequisites

* [.NET Core SDK 2+](https://www.microsoft.com/net/download/windows)
* Code editor. I used [Visual Studio Code](https://code.visualstudio.com/)

## Run the Tests

```bash
dotnet test
```

The three projects should restore dependencies, build, and then the system will attempt to run the test framework on all three projects. Since the Business project does not contain any tests, the command line with note that no tests are available and move on.
