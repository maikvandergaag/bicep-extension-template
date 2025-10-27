# Bicep Extension Template

A .NET template for creating custom Bicep extensions that extend Azure Bicep with custom resource types and functionality.

## Overview

This template provides a starting point for building custom Bicep extensions using .NET 9.0 and the Azure Bicep Local Extension framework. It includes example implementations of resource handlers, models, and deployment scripts to help you quickly create and publish your own Bicep extensions.

## Features

- **Pre-configured .NET 9.0 project structure** for Bicep extension development
- **Example resource handler** demonstrating operations
- **Type-safe resource models** with JSON serialization
- **Publishing scripts** for local and container registry deployment
- **Self-contained executable** output for easy distribution
- **Template engine integration** for quick project scaffolding

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Bicep CLI](https://learn.microsoft.com/azure/azure-resource-manager/bicep/install) (for testing)
- PowerShell 7+ (for publishing scripts)
- Optional: Azure Container Registry (for publishing)

## Installation

Install the template from NuGet:

```powershell
dotnet new install Bicep.Extension.Templates
```

## Usage

### Creating a New Extension

Create a new Bicep extension project using the template:

```powershell
dotnet new bicepext -n MyBicepExtension -extension MyBicepExtension
```

This will generate a new project with the following structure:

```
MyBicepExtension/
├── script/
│   ├── publish.ps1          # Publishing script
│   └── README.md
├── src/
│   ├── MyBicepExtension.csproj
│   ├── Program.cs           # Extension entry point
│   ├── Handler/
│   │   └── ExampleHandler.cs    # Resource handler
│   └── Model/
│       ├── ExampleResource.cs   # Resource model
│       └── ExampleResourceIdentifiers.cs
```

### Building the Extension

Build the extension project:

```powershell
cd MyBicepExtension/src
dotnet build
```

### Publishing the Extension

#### Local Publishing

Publish the extension locally for testing:

```powershell
cd ../script
.\publish.ps1
```

#### Container Registry Publishing

Publish to an Azure Container Registry:

```powershell
.\publish.ps1 -Registry $true -RegistryUrl "myregistry.azurecr.io" -Tag "1.0.0" -Repository "bicep-extensions"
```