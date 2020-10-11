# .NET GitHub Actions and Gitflow Example

## Tasks

- [X] Create a Gitflow project with `git flow`
- [X] Create a skeleton .NET console application that prints its version number
- [X] Create a sample test assembly that has a passing test
- [X] Create a GitHub Action to build the project and run the tests
- [X] Verify that a good build succeeds
- [ ] Verify that a broken build is bad
- [ ] Verify that a build with failing tests is bad
- [ ] Create a GitHub Action to create a release when making a commit and stamp
      build artifacts with the release name
- [ ] Verify that the release artifacts are complete
- [ ] Verify that the release artifacts have the correct version number

## Initial creation notes

The way I initially created the repo is as follows:

```bash
~/Source/bcr/dotnet-actions-gitflow$ git flow init
Initialized empty Git repository in /Users/blakeramsdell/Source/bcr/dotnet-actions-gitflow/.git/
No branches exist yet. Base branches must be created now.
Branch name for production releases: [master]
Branch name for "next release" development: [develop]

How to name your supporting branch prefixes?
Feature branches? [feature/]
Bugfix branches? [bugfix/]
Release branches? [release/]
Hotfix branches? [hotfix/]
Support branches? [support/]
Version tag prefix? []
Hooks and filters directory? [/Users/blakeramsdell/Source/bcr/dotnet-actions-gitflow/.git/hooks]
~/Source/bcr/dotnet-actions-gitflow$
```

```bash
~/Source/bcr/dotnet-actions-gitflow$ dotnet new console -o Bcr.Example.Gitflow
~/Source/bcr/dotnet-actions-gitflow$ dotnet new xunit -o Bcr.Example.Gitflow.Test
~/Source/bcr/dotnet-actions-gitflow$ dotnet new sln
~/Source/bcr/dotnet-actions-gitflow$ dotnet sln add Bcr.Example.Gitflow
~/Source/bcr/dotnet-actions-gitflow$ dotnet sln add Bcr.Example.Gitflow.Test
```
