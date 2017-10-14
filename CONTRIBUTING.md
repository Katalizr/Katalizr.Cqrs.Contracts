# Contributing to Katalizr.Cqrs.Contracts

Katalizr.Cqrs.Contracts is one of Katalizr's open source projects that is both under development. We're still working out the kinks to make contributing to this project as easy and transparent as possible, but we're not quite there yet. Hopefully this document makes the process for contributing clear and answers some questions that you may have.

## Code of Conduct
This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Our Development Process

The core team works directly on GitHub and all work is public.

### `develop` is unsafe

We will do our best to keep `develop` in good shape, with tests passing at all times.

### Workflow and Pull Requests

The core team will be monitoring for pull requests. When we get one, we'll analyze it, discuss about it with you and from here, we'll need to get another person to sign off on the changes and then merge the pull request. We'll do our best to provide updates and feedback throughout the process.

*Before* submitting a pull request, please make sure the following is done…

1. Fork the repo and create your branch from `develop`.
   A guide on how to fork a repository: https://help.github.com/articles/fork-a-repo/
   
   Open terminal (e.g. Terminal, iTerm, Git Bash or Git Shell) and type:
   ```sh
   git clone https://github.com/<your_username>/Katalizr.Cqrs.Contracts
   cd Katalizr.Cqrs.Contracts
   git checkout -b my_branch
   ```
   Note:
   Replace `<your_username>` with your GitHub username

2. Katalizr.Cqrs.Contracts uses [.NET Core](https://www.microsoft.com/net/core)
   for running tests. If you haven't already done so,
   please install it.

3. Run `dotnet restore`.
4. If you've added code that should be tested, add tests. You
   can use watch mode that continuously transforms changed files
   to make your life easier.

   ```sh
   # in the background
   dotnet test
   ```

5. If you've changed APIs, update the documentation.

## Bugs

### Where to Find Known Issues

We will be using GitHub Issues for our public bugs. We will keep a close eye on this and try to make it clear when we have an internal fix in progress. Before filing a new issue, try to make sure your problem doesn't already exist.

### Reporting New Issues

The best way to get your bug fixed is to provide a reduced test case. Please provide a public repository with a runnable example.
