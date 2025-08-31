# Copilot Instructions for RimWorld Mod: Cut Plants Before Building (Continued)

## Mod Overview and Purpose
The "Cut Plants Before Building (Continued)" mod automates the process of cutting plants that interfere with construction in RimWorld. Specifically, it designates plants for cutting when they are in the way of planned construction site, installation site, or roof area. The purpose of the mod is to streamline building operations by removing obstructions automatically while respecting the mod settings and game environment.

## Key Features and Systems
- **Automatic Plant Designation**: Automatically designates plants for cutting if they obstruct planned construction or roof area.
- **Special Trees Protection**: Keeps important trees like Anima, Gauranlen, and Harbringer from being automatically marked for cutting.
- **Mod Settings**: Allows customization through settings, including:
  - Default auto-cut state
  - Option to dig up rather than cut
  - Restriction of cutting to pawns with the Plant Cutting ability
- **User Control**: Offers a toggle option for automatic felling designation via a new play settings icon button or default shortcut key (Backslash).
- **Multi-Language Support**: English, Japanese, Polish, Korean, and Simplified Chinese.
- **Supported by Harmony**: Uses Harmony Library for seamless game patching and modifications.

## Coding Patterns and Conventions
- **Class Naming**: Public classes are exported located in files like `AutoBuildRoofAreaSetter_TryGenerateAreaNow.cs`, while internal classes specific to the mod are prefixed with 'Internal'.
- **Method Structure**: Methods perform specific, well-defined tasks, focusing on extending or modifying existing game behaviors without altering core game files.
- **Namespacing**: Classes and methods are organized in a manner consistent with RimWorld modding best practices, focused on clarity and ease of use.
- **Commenting**: Use XML comments to describe class and method functionalities.

## XML Integration
- **Language Files**: Support for multi-language by adding translation files, provided by community contributors.
- **Mod Settings XML**: Parameters for enabling/disabling features and player preferences are configured through XML.

## Harmony Patching
- **Patch Locations**: Entry points are defined for interacting with RimWorld's code, notably when setting the area for constructions, building, and installations.
- **Conflicts Management**: All patches aim to maintain maximum compatibility with other mods using Harmony's patching techniques.

## Suggestions for Copilot
- **Common Patterns**: Encourage code suggestions that match the established class structures and naming conventions.
- **Harmony Integration**: Suggest efficient patching strategies adhering to Harmony's optimization.
- **Localization Support**: Automatically generate code for adding and updating translation files.
- **Settings Management**: Propose code improvements for managing and retrieving user settings.
- **Modular Design**: Facilitate writing code that enhances functionality without dependency conflicts.
- **Performance Tips**: Optimize heavy computation areas and reduce function call overhead.

End of Instructions
