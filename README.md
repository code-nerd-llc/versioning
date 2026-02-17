# Versioning

A .NET 8 console application demonstrating automated semantic versioning with [Versionize](https://github.com/versionize/versionize) and GitHub Actions.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

```bash
dotnet restore
dotnet build
dotnet run --project VersionTestApp
```

## How It Works

On every push to `master`, a GitHub Actions workflow:

1. Builds the project
2. Runs [Versionize](https://github.com/versionize/versionize) to analyze commits since the last release
3. Bumps the version in `VersionTestApp/VersionTestApp.csproj`, updates `CHANGELOG.md`, and creates a git tag
4. Pushes the changes and creates a GitHub Release

Version bumps are determined by commit messages following the [Conventional Commits](https://www.conventionalcommits.org/) specification:

| Prefix | Version Bump |
|--------|-------------|
| `fix:` | Patch (1.0.x) |
| `feat:` | Minor (1.x.0) |
| `feat!:` or `BREAKING CHANGE:` | Major (x.0.0) |

Commits without a `feat` or `fix` prefix are considered insignificant and do not trigger a release.

## Setup

To use this workflow in your own repository, add a Personal Access Token as a repository secret named `TEST_PAT` with permissions to push commits and tags.
