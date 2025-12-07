# Bicep Extension Template

A .NET template package for quickly scaffolding custom Bicep extensions using the Azure Bicep Local Extension framework.

## About This Package

This NuGet template package provides a project template (`bicep-extension`) that generates a fully functional Bicep extension project with example implementations. It's designed to help developers quickly bootstrap custom Bicep extensions without writing boilerplate code.

## Installation

Install the template package globally using the .NET CLI:

```powershell
dotnet new install Bicep.Extension.Templates
```

## Usage

### Create a New Extension Project

Once installed, create a new Bicep extension project:

```powershell
dotnet new bicep-extension -n MyCustomExtension --extension MyCustomExtension
```

### Template Parameters

The template supports the following parameters:

#### `--extension` (Required)
The name of your Bicep extension. This will be used throughout the generated code.

```powershell
dotnet new bicep-extension --extension "MyCompany.BicepExtension"
```

#### `--resource` (Optional)
The name of the example resource type in code. This replaces "Example" in the generated handler and model files.

```powershell
dotnet new bicep-extension --extension "MyCompany.BicepExtension" --resource "Database"
```

This will generate:
- `DatabaseHandler.cs` instead of `ExampleHandler.cs`
- `DatabaseResource.cs` instead of `ExampleResource.cs`
- `DatabaseResourceIdentifiers.cs` instead of `ExampleResourceIdentifiers.cs`

### Complete Example

```powershell
# Create a new extension with custom resource name
dotnet new bicep-extension -n MyBicepExtension --extension "MyCompany.CloudExtension" --resource "StorageAccount"

# Navigate to the project
cd MyBicepExtension

# Build the extension
cd src
dotnet build

# Publish locally (using the included script)
cd ../script
.\publish.ps1 -Target "./output" -ExtensionName "MyCompany.CloudExtension"
```

## What Gets Generated

The template creates the following project structure:

```
YourProjectName/
├── script/
│   ├── publish.ps1          # PowerShell script for publishing the extension
│   └── README.md            # Publishing documentation
├── src/
│   ├── Bicep.Extension.csproj       # Project file
│   ├── Program.cs                   # Extension entry point
│   ├── Handler/
│   │   └── [Resource]Handler.cs    # Example resource handler
│   └── Model/
│       ├── [Resource]Resource.cs              # Resource model
│       └── [Resource]ResourceIdentifiers.cs   # Resource identifiers
```

### Generated Components

- **Program.cs**: Configures the Bicep extension host with your extension name and registers resource handlers
- **Resource Handler**: Implements `Preview` and `CreateOrUpdate` operations for your custom resource type
- **Resource Model**: Defines the schema for your custom resource with JSON serialization attributes
- **Publishing Script**: Multi-platform build and publishing automation for local and container registry deployment

## Key Features

- **Parameterized scaffolding** with customizable extension and resource names
- **Complete working example** with handler and model implementations
- **Pre-configured for .NET 9.0** and self-contained deployment
- **Publishing automation** with cross-platform build support (Windows, Linux, macOS)
- **Type-safe resource handling** using strongly-typed models
- **Azure Bicep Local Extension** framework integration (v0.37.4)

## Next Steps

After generating your project:

1. **Customize the resource model** in `Model/[Resource]Resource.cs` to define your resource schema
2. **Implement business logic** in `Handler/[Resource]Handler.cs` for Preview and CreateOrUpdate operations
3. **Update extension metadata** in `Program.cs` (name, version)
4. **Build and test** your extension locally
5. **Publish** using the included PowerShell script

## Requirements

- .NET 9.0 SDK or later
- PowerShell 7+ (for publishing scripts)
- Bicep CLI (for testing your extension)

## Template Information

- **Short Name**: `bicep-extension`
- **Language**: C#
- **Type**: Project template
- **Author**: maikvandergaag
- **Classifications**: C#, Bicep, Extension

## Uninstalling

To remove the template package:

```powershell
dotnet new uninstall Bicep.Extension.Templates
```

## Support

For issues, questions, or contributions, please visit:
- GitHub Repository: https://github.com/maikvandergaag/bicep-extension-template
- NuGet Package: https://www.nuget.org/packages/bicep-extension-templates

## Additional Resources

- [Azure Bicep Documentation](https://learn.microsoft.com/azure/azure-resource-manager/bicep/)
- [Bicep Extensibility Overview](https://learn.microsoft.com/azure/azure-resource-manager/bicep/extensibility)
- [.NET Template Development](https://learn.microsoft.com/dotnet/core/tools/custom-templates)

## Version

**1.0.0** - Initial release with parameterized extension and resource naming

**1.0.2** - Fixed renaming of resource an fixed file path in publish.ps1

---

*This template package is designed to accelerate Bicep extension development by providing a solid foundation with best practices built-in.*
