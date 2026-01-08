# Keyboard Maestro `.kmmacros` File Format Guide

## Critical Structure Requirements

### Top-Level Structure
A `.kmmacros` file contains an **array of macro groups**, NOT individual macros. Each group can contain multiple macros.

```xml
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<array>
    <!-- Each <dict> here is a MACRO GROUP -->
    <dict>
        <!-- Macro Group properties -->
        <key>Macros</key>
        <array>
            <!-- Individual macros go here -->
        </array>
    </dict>
</array>
</plist>
```

## Macro Group Structure (Top-Level Dictionary)

Each macro group dictionary **MUST** contain:

| Key | Type | Required | Description |
|-----|------|----------|-------------|
| `Activate` | `<string>` | ✅ | Usually `"Normal"` |
| `CreationDate` | `<real>` | ✅ | Timestamp as real number (e.g., `610445107.00866795`) |
| `CustomIconData` | `<string>` | ✅ | Icon identifier (e.g., `"KMEP-Notifications"`) |
| `Macros` | `<array>` | ✅ | Array of macro dictionaries |
| `Name` | `<string>` | ✅ | Group name |
| `ToggleMacroUID` | `<string>` | ✅ | UUID string |
| `UID` | `<string>` | ✅ | UUID string for the group |

### Example Macro Group:
```xml
<dict>
    <key>Activate</key>
    <string>Normal</string>
    <key>CreationDate</key>
    <real>610445107.00866795</real>
    <key>CustomIconData</key>
    <string>KMEP-Notifications</string>
    <key>Macros</key>
    <array>
        <!-- Individual macros go here -->
    </array>
    <key>Name</key>
    <string>Windows Manager</string>
    <key>ToggleMacroUID</key>
    <string>768F59FC-682B-450B-8F5C-9D64EF01805F</string>
    <key>UID</key>
    <string>E8919D3F-65B3-45D5-9F33-1E5AA56046D7</string>
</dict>
```

## Individual Macro Structure (Inside `Macros` Array)

Each macro dictionary **MUST** contain:

| Key | Type | Required | Description |
|-----|------|----------|-------------|
| `Actions` | `<array>` | ✅ | Array of action dictionaries |
| `CreationDate` | `<real>` | ✅ | Timestamp as real number |
| `CustomIconData` | `<string>` | ✅ | Icon identifier |
| `ModificationDate` | `<real>` | ✅ | Timestamp as real number |
| `Name` | `<string>` | ✅ | Macro name |
| `Triggers` | `<array>` | ✅ | Array of trigger dictionaries |
| `UID` | `<string>` | ✅ | UUID string (unique per macro) |

### Example Macro:
```xml
<dict>
    <key>Actions</key>
    <array>
        <!-- Action dictionaries -->
    </array>
    <key>CreationDate</key>
    <real>610455053.70507002</real>
    <key>CustomIconData</key>
    <string>KMEP-Down</string>
    <key>ModificationDate</key>
    <real>610455423.02370298</real>
    <key>Name</key>
    <string>Window Snap Up</string>
    <key>Triggers</key>
    <array>
        <!-- Trigger dictionaries -->
    </array>
    <key>UID</key>
    <string>189812C3-67A1-4737-AEF3-6F3203D00FA7</string>
</dict>
```

## Action Structure

Each action dictionary **MUST** contain:

| Key | Type | Required | Description |
|-----|------|----------|-------------|
| `MacroActionType` | `<string>` | ✅ | Action type (see list below) |

Additional keys depend on the `MacroActionType`. Common action types:

- `SetVariableToText`
- `ManipulateWindow`
- `IfThenElse`
- `For` (loop)
- `SwitchToLastApplication`
- `Cancel` (with `Action` = `"BreakFromLoop"`)

### Example Action:
```xml
<dict>
    <key>MacroActionType</key>
    <string>SetVariableToText</string>
    <key>Text</key>
    <string>%ScreenVisible%Front%</string>
    <key>Variable</key>
    <string>Screen__Front</string>
</dict>
```

## Trigger Structure

Each trigger dictionary **MUST** contain:

| Key | Type | Required | Description |
|-----|------|----------|-------------|
| `MacroTriggerType` | `<string>` | ✅ | Usually `"HotKey"` |

For HotKey triggers, also include:
- `FireType`: `<string>` (usually `"Pressed"`)
- `KeyCode`: `<integer>` (key code number)
- `Modifiers`: `<integer>` (modifier flags)

### Example Trigger:
```xml
<dict>
    <key>FireType</key>
    <string>Pressed</string>
    <key>KeyCode</key>
    <integer>126</integer>
    <key>MacroTriggerType</key>
    <string>HotKey</string>
    <key>Modifiers</key>
    <integer>6144</integer>
</dict>
```

## Common Mistakes AI Makes

### ❌ WRONG: Individual macros at top level
```xml
<array>
    <dict>
        <key>Name</key>
        <string>My Macro</string>
        <!-- Missing Macros array wrapper -->
    </dict>
</array>
```

### ✅ CORRECT: Macros inside groups
```xml
<array>
    <dict>
        <key>Name</key>
        <string>My Group</string>
        <key>Macros</key>
        <array>
            <dict>
                <key>Name</key>
                <string>My Macro</string>
            </dict>
        </array>
    </dict>
</array>
```

### ❌ WRONG: Missing required fields
```xml
<dict>
    <key>Name</key>
    <string>My Macro</string>
    <!-- Missing UID, CreationDate, etc. -->
</dict>
```

### ✅ CORRECT: All required fields present
```xml
<dict>
    <key>Name</key>
    <string>My Macro</string>
    <key>UID</key>
    <string>UNIQUE-UUID-HERE</string>
    <key>CreationDate</key>
    <real>610445107.00866795</real>
    <!-- ... all other required fields ... -->
</dict>
```

### ❌ WRONG: Dates as strings
```xml
<key>CreationDate</key>
<string>2024-01-01</string>
```

### ✅ CORRECT: Dates as real numbers
```xml
<key>CreationDate</key>
<real>610445107.00866795</real>
```

### ❌ WRONG: Missing MacroActionType
```xml
<dict>
    <key>Text</key>
    <string>Hello</string>
    <!-- Missing MacroActionType -->
</dict>
```

### ✅ CORRECT: MacroActionType specified
```xml
<dict>
    <key>MacroActionType</key>
    <string>SetVariableToText</string>
    <key>Text</key>
    <string>Hello</string>
</dict>
```

## UUID Generation

UIDs must be valid UUIDs in the format: `XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX`

Generate using:
- macOS: `uuidgen` command
- Python: `import uuid; str(uuid.uuid4()).upper()`
- Online UUID generators

## Date Format

Dates are **real numbers** (floating-point timestamps), not strings or integers.

- Format: `<real>610445107.00866795</real>`
- These appear to be seconds since a reference date
- Use Keyboard Maestro's export to see valid date formats

## Validation Checklist

Before importing, verify:

- [ ] File starts with proper XML declaration and DOCTYPE
- [ ] Root element is `<plist version="1.0">`
- [ ] Top-level is `<array>` containing `<dict>` elements (macro groups)
- [ ] Each macro group has: `Activate`, `CreationDate`, `CustomIconData`, `Macros`, `Name`, `ToggleMacroUID`, `UID`
- [ ] Each macro has: `Actions`, `CreationDate`, `CustomIconData`, `ModificationDate`, `Name`, `Triggers`, `UID`
- [ ] Each action has `MacroActionType`
- [ ] Each trigger has `MacroTriggerType`
- [ ] All UIDs are valid UUIDs
- [ ] All dates are `<real>` numbers, not strings
- [ ] XML is well-formed (validate with `xmllint`)

## Testing

1. **Validate XML**: `xmllint --noout your_file.kmmacros`
2. **Import Safely**: Use `File > Import Macros Safely...` in Keyboard Maestro
3. **Check for Errors**: Keyboard Maestro will report import errors if format is invalid

## Best Practice

**Always export a working macro from Keyboard Maestro first**, then use it as a template. This ensures you have the correct structure and all required fields.
