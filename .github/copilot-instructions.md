# GitHub Copilot Instructions for "Cut Plants Before Building (Continued)" Mod

### Mod Overview and Purpose
The **Cut Plants Before Building (Continued)** mod is designed to enhance the building and construction process in RimWorld by automatically designating plants for cutting when they are located on a planned construction, installation, or roof area. This makes construction smoother and more efficient, as plants that would obstruct building are handled proactively.

### Key Features and Systems
- **Automatic Plant Cutting:** The mod automatically designates plants for cutting in any area marked for construction, installation, or roofing.
- **Special Tree Protection:** Anima trees, Gauranlen trees, and Harbringer trees are exempt from automatic cutting to preserve important game mechanics.
- **Mod Settings:** Players can configure the default state for automatic plant cutting, determine whether digging is allowed if necessary, and restrict cutting to pawns with plant cutting capabilities.
- **Toggle Functionality:** Players can toggle the auto-felling designation mode via a new play settings button or a default shortcut key (`Backslash`).
- **Language Support:** The mod supports multiple languages including English, Japanese, Polish, Korean, and Chinese Simplified.

### Coding Patterns and Conventions
- **Class Design:** The mod uses a mix of public and internal classes, with methods corresponding to the operations needed for automatic designation and settings control.
- **Modular Structure:** Individual classes handle specific functionalities, promoting modularity and reusability.
- **Conventions:** The project adheres to standard C# conventions, with PascalCase for class and method names, and uses internal access modifiers where appropriate to encapsulate functionality.

### XML Integration
- XML files are used to define mod settings, language translations, and other game data integrations. Ensure all XML files are valid and match the required schema for RimWorld mods.

### Harmony Patching
- The mod is powered by the Harmony Patch Library, allowing it to intercept game methods and alter behavior without modifying the original game code directly.
- Ensure patches are well-documented and do not conflict with other mods. Make strategic use of Prefix, Postfix, and Transpiler methods provided by Harmony.

### Suggestions for Copilot
- **Automation Logic:** Assist in generating logic for conditional plant cutting based on mod settings and player preferences.
- **UI Enhancements:** Generate suggestions for improving user interface elements such as the toggle button or settings menu.
- **Performance Optimization:** Provide code suggestions to optimize harmony patches for better performance, especially for large maps and numerous pawns.
- **Localization Updates:** Assist in maintaining language files and ensuring new strings are properly translated and integrated.
- **Error Handling:** Suggest improvements for error handling and logging to aid in debugging and ensure smooth user experience.

This instruction file serves as a guide for further mod development and improvement using GitHub Copilot. Ensure that any generated code aligns with the overall design and functionality expected from the mod.


This `.github/copilot-instructions.md` file provides a comprehensive set of instructions and guidance for utilizing GitHub Copilot effectively in the context of developing and maintaining the "Cut Plants Before Building (Continued)" mod for RimWorld.
