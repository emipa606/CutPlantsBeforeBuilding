# GitHub Copilot Instructions for "Cut plants before building (Continued)" Mod

## Mod Overview and Purpose

"Cut plants before building (Continued)" is a mod initially created by 民火 and continued by the current project contributors. The mod's primary function is to automatically designate plants for cutting or digging when a construction or installation plan overlaps with them in RimWorld. It enhances building workflow efficiency by ensuring that plants do not obstruct constructions. The mod supports multiple languages and integrates seamlessly into the RimWorld gameplay experience, providing settings for customization and leveraging the Harmony Patch Library for code modifications.

## Key Features and Systems

- **Automatic Plant Cutting**: Automatically designate plants for cutting or digging when they conflict with planned construction, installation, or roofing areas.
- **Mod Settings**: Allows players to toggle the auto-felling option through mod settings, including setting defaults and enabling only skilled plant cutters to perform the actions.
- **Exclusions for Special Trees**: The mod respects and excludes specific trees like the Anima tree, Gauranlen tree, and Harbringer tree from being auto-designated for cutting.
- **User Interface**: Includes a new icon button in the play settings and a configurable shortcut key (default is Backslash) for toggling the automatic designation mode.
- **Multi-language Support**: Offers translations in English, Japanese, Polish, Korean, and Simplified Chinese to reach a broader audience.
- **Error Reporting and Support**: Encourages using Discord for error reporting and sharing solutions directly on GitHub for collaborative development and troubleshooting.

## Coding Patterns and Conventions

- **Project Structure**: The mod is composed of 12 C# files and 2 XML files, following clear naming conventions that reflect their functionality (e.g., `CutPlantsBeforeBuildingMod.cs`, `Main.cs`).
- **Naming Conventions**: Classes and methods follow PascalCase convention (e.g., `CutPlantsBeforeBuildingMod`, `DoSettingsWindowContents`). Public members are well-named to represent their purpose.
- **Comments and Documentation**: Ensure that all methods are well-documented for clarity, with comments explaining the function and necessity of complex code blocks.

## XML Integration

- **XML Files**: Use XML files to define key bindings and integrate with Harmony for dependency management.
- **Localization**: XML is also used for translation management to support multiple languages, utilizing translation templates for the mod's key bindings.

## Harmony Patching

- **Harmony Integration**: Uses Harmony to patch methods in RimWorld that handle construction and plant designation processes. This allows for non-destructive modifications to the base game.
- **Patch Management**: Maintain a clear organization of Harmony patches within the project. Each patch should have a corresponding comment explaining its purpose and impact on game mechanics.

## Suggestions for Copilot

- **Intellisense Utilization**: Leverage Copilot for proposing code completions and suggestions, especially when creating Harmony patches or integrating new features with existing systems.
- **Pattern Recognition**: Use Copilot's ability to recognize patterns to maintain consistent coding practices across different files, such as managing plant designation logic or UI updates.
- **Expand Language Support**: Suggest additional translations or improvements in text used within the mod based on existing patterns.
- **Debugging Assistance**: Utilize the Copilot to assist in debugging by suggesting potential fixes or improvements when interacting with Harmony patches or mod settings.

By adhering to these guidelines and suggestions, developers can ensure the mod remains robust, efficient, and easy to maintain while providing an enhanced experience for RimWorld players.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

