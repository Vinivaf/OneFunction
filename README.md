# C# Tool for Generating MD5 Hashes in Base64

This C# tool enables users to input strings and receive their corresponding MD5 hashed values in Base64 representation. It provides a command-line interface for interaction.

## Functionality

1. **Input Prompt:** Upon execution, the tool prompts the user to input a string for hashing.

2. **Input Handling:** It accepts user input character by character, masking the input for privacy.

3. **Hash Generation:** Once the user submits the input, the tool computes the MD5 hash of the input string using UTF-8 encoding.

4. **Representation:** The resulting MD5 hash is converted into its Base64 and Base85 (Additional Z85) representations.

5. **Display:** The Base64-encoded MD5 hash is displayed on the console as the output.

6. **Continual Operation:** The tool continuously prompts for input and generates corresponding Base64 MD5 hashes until manually terminated.

## Installation

### Installing a Specific Version

To install a specific version of the `OneFunction` tool globally, you can use the following command:

```bash
dotnet tool install --global OneFunction --version 1.0.0
```

Replace `OneFunction` with the actual name of your tool, and specify the desired version (in this case, `1.0.0`). This command will install the specified version of the tool globally on your system.

### Local Installation

If you have the `.nupkg` file locally, you can install it using the `-s` or `--add-source` option:

```bash
dotnet tool install --global OneFunction --add-source "C:\[YourFullPath]\OneFunction"
```

Replace the `source` path with the directory containing the `.nupkg` file for the `OneFunction` tool.

## Project Details

- **Target Framework:** .NET 8.0
- **Implicit Usings:** Enabled
- **Nullable Reference Types:** Enabled
- **Packaging Configuration:** Outputs as a tool with a specified output path for the package.
