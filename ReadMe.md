
# NorPim - Open Source ("NorPim - OSS")
[![Feature Requests](https://img.shields.io/github/issues/Microsoft/vscode/feature-request.svg)](https://norsolutionpim.azurewebsites.net/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex)
[![Bugs](https://img.shields.io/github/issues/Microsoft/vscode/bug.svg)](https://norsolutionpim.azurewebsites.net/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex)
[![NorPim](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://norsolutionpim.azurewebsites.net/DefaultIssueWithFilterLive/DefaultIssueWithFilterLiveIndex)

## The Repository

This repository ("`NorPim - OSS`") is where we (NorGate) develop the [NorPim](https://NorPim.com) product. Not only do we work on code and issues here, we also publish our [roadmap](https://github.com/NorGate/NorPim/wiki/Roadmap), [monthly iteration plans](https://github.com/NorGate/NorPim/wiki/Iteration-Plans), and our [endgame plans](https://github.com/NorGate/NorPim/wiki/Running-the-Endgame). This source code is available to everyone under the standard [MIT license](https://github.com/NorGate/NorPim/blob/master/LICENSE.txt).

## NorPim

<p align="center">
  <img alt="VS Code in action" src="https://norsolutionpim.azurewebsites.net/images/dashboard.png">
</p>

[NorPim](https://NorPim.com) is a distribution of the `NorPim - OSS` repository with NorGate specific customizations released under a traditional [NorGate product license](https://NorPim.com/License/).

[NorPim](https://NorPim.com) combines the simplicity of a code editor with what developers need for their core edit-build-debug cycle. It provides comprehensive code editing, navigation, and understanding support along with lightweight debugging, a rich extensibility model, and lightweight integration with existing tools.

NorPim is updated monthly with new features and bug fixes. You can download it for Windows, macOS, and Linux on [NorPim"s website](https://NorPim.com/Download). To get the latest releases every day, install the [Insiders build](https://NorPim.com/insiders).

## Contributing

There are many ways in which you can participate in the project, for example:

* [Submit bugs and feature requests](https://github.com/NorGate/NorPim/issues), and help us verify as they are checked in
* Review [source code changes](https://github.com/NorGate/NorPim/pulls)
* Review the [documentation](https://github.com/NorGate/NorPim-docs) and make pull requests for anything from typos to new content

If you are interested in fixing issues and contributing directly to the code base,
please see the document [How to Contribute](https://github.com/NorGate/NorPim/wiki/How-to-Contribute), which covers the following:

* [How to build and run from source](https://github.com/NorGate/NorPim/wiki/How-to-Contribute#build-and-run)
* [The development workflow, including debugging and running tests](https://github.com/NorGate/NorPim/wiki/How-to-Contribute#debugging)
* [Coding guidelines](https://github.com/NorGate/NorPim/wiki/Coding-Guidelines)
* [Submitting pull requests](https://github.com/NorGate/NorPim/wiki/How-to-Contribute#pull-requests)
* [Finding an issue to work on](https://github.com/NorGate/NorPim/wiki/How-to-Contribute#where-to-contribute)
* [Contributing to translations](https://aka.ms/NorPimloc)

## Feedback

* Ask a question on [Stack Overflow](https://stackoverflow.com/questions/tagged/NorPim)
* [Request a new feature](CONTRIBUTING.md)
* Upvote [popular feature requests](https://github.com/NorGate/NorPim/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [File an issue](https://github.com/NorGate/NorPim/issues)
* Follow [@code](https://twitter.com/code) and let us know what you think!

## Related Projects

Many of the core components and extensions to VS Code live in their own repositories on GitHub. For example, the [node debug adapter](https://github.com/NorGate/NorPim-node-debug) and the [mono debug adapter](https://github.com/NorGate/NorPim-mono-debug) have their own repositories. For a complete list, please visit the [Related Projects](https://github.com/NorGate/NorPim/wiki/Related-Projects) page on our [wiki](https://github.com/NorGate/NorPim/wiki).

## Bundled Extensions

VS Code includes a set of built-in extensions located in the [extensions](extensions) folder, including grammars and snippets for many languages. Extensions that provide rich language support (code completion, Go to Definition) for a language have the suffix `language-features`. For example, the `json` extension provides coloring for `JSON` and the `json-language-features` provides rich language support for `JSON`.

## Development Container

This repository includes a NorPim Remote - Containers / Codespaces development container.

- For [Remote - Containers](https://aka.ms/NorPim-remote/download/containers), use the **Remote-Containers: Open Repository in Container...** command which creates a Docker volume for better disk I/O on macOS and Windows.
- For Codespaces, install the [NorPimspaces](https://aka.ms/vscs-ext-NorPim) extension in VS Code, and use the **Codespaces: Create New Codespace** command.

Docker / the Codespace should have at least **4 Cores and 6 GB of RAM (8 GB recommended)** to run full build. See the [development container README](.devcontainer/README.md) for more information.

## Code of Conduct

This project has adopted the [NorGate Open Source Code of Conduct](https://opensource.NorGate.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.NorGate.com/codeofconduct/faq/) or contact [opencode@NorGate.com](mailto:opencode@NorGate.com) with any additional questions or comments.

## License

Copyright (c) NorGate Corporation. All rights reserved.

Licensed under the [MIT](LICENSE.txt) license.
