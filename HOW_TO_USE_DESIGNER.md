# How to Use the Visual Studio Designer with This Project

## What Was Changed

The following forms have been converted from "code-only" to **Designer-compatible** format:

| Form | Files Created |
|------|--------------|
| Login Form | `LoginForm.cs` + `LoginForm.Designer.cs` |
| Register Form | `AuthForms.cs` + `RegisterForm.Designer.cs` |
| Change Password Form | `AuthForms.cs` + `ChangePasswordForm.Designer.cs` |

## How to Open in Designer View

1. Open the solution in **Visual Studio 2022**
2. In **Solution Explorer**, expand the `Forms` folder
3. You will see each `.cs` file with a nested `.Designer.cs` file underneath it
4. **Double-click** the `.cs` file (e.g. `LoginForm.cs`)
5. Click **View → Designer** (or press `Shift+F7`)
6. The form opens in **drag-and-drop Designer view** ✅

## What You Can Do in Designer

- **Move controls** by dragging them on the canvas
- **Resize controls** using the handles
- **Change properties** in the Properties panel (F4)
- **Add new controls** from the Toolbox (Ctrl+Alt+X)
- **Wire up events** by double-clicking controls
- Visual Studio will write the code changes back to `*.Designer.cs` automatically

## Important Rules

- **Never manually edit** `*.Designer.cs` files — Visual Studio owns those
- **Your logic** (button clicks, validation, etc.) stays in the plain `.cs` file
- Only touch `*.Designer.cs` if Visual Studio is not open

## Forms NOT Yet Converted (still code-only)

These forms build their UI in code (they work fine, just not drag-and-drop):
- `BaseDashboard.cs` — Abstract base, not typically opened in Designer
- `AdminDashboard.cs`, `SuperAdminDashboard.cs`, `CustomerDashboard.cs`
- `DashboardViews.cs`, `FuelPanel.cs`, `OrdersPanel.cs`, `OtherPanels.cs`, `UsersPanel.cs`

To convert more forms, follow the same pattern: split into `.cs` + `.Designer.cs` partial classes.
