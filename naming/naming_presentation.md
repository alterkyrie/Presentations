---
marp: true
---

# C# Naming & Architecture: From Legacy to Clarity
*by Anatolii Pastushuk*

---
## The Context vs. Identity Dilemma
Visual Studio maps **Namespaces** to folders, creating a temptation to use "Minimalist Naming."

**The Scenario:** Class: `CBase` 
Namespace - `com.dimins.modules.spectreflow.ViewModel.Nodes.Input`

**The Call:** `var node = new ViewModel.Nodes.Input.CBase();`

---
## Why Minimalist Naming Fails
While it avoids redundancy, it creates **Technical Debt**:
- **Ambiguity:** If you have `Input.CBase` and `Output.CBase`, you cannot use both in one file without ugly aliases.
- **Developer Experience:** "Go to Symbol" (Ctrl+T) returns 50 identical results.
- **Reviewability:** `void Process(CBase node)` tells a reviewer nothing about the object's logic or role.
---
## The War on Cryptic Abbreviations
**Rule:** If you have to ask "What does this mean?", it shouldn't be a shortcut.
- **The Bad (Cryptic):** * `Ds` (DataSource? DomainService? DataStorage?)
    - `Cfg` (Config? Centrifuge?)
    - `Svc` (Service? Savic?)
- **The Good (Industry Standards):**
    - `Id` (Identifier)
    - `Dto` (Data Transfer Object)
    - `URL` (Uniform Resource Locator)
- **Verdict:** 7 extra characters for `Configuration` is cheaper than 10 minutes of a new developer's confusion.
---
## Namespace Philosophy: Why Folders Matter

**Legacy Pattern:** One general namespace for the whole project.
- **Result:** Name collisions and the need for massive class names like `SpectreFlowInputNodeViewModel`.
**Modern Pattern:** Namespace strictly follows folder structure.
- **Why avoid "General" Namespaces?**
    - **Discovery:** Namespaces act as a "Map." If it's in `...Nodes.Input`, I know exactly where to find the source.
    - **Access Control:** Easier to manage `internal` vs `public` visibility within modules.
    - **Separation of Concerns:** Prevents accidental dependencies between unrelated modules.
---
## The Mandatory Technical Suffix
### Correcting the `CBaseInputNode` Error
A class name must answer: **"What is my lifecycle?"**
- **The Missing Link:** `CBaseInputNode` sounds like a **Data Model** (a static record).
- **The Contract:** In MVVM, the `ViewModel` suffix is a mandatory "signpost" for UI logic and state management.
- **Optimal Choice:** `CBaseInputNodeViewModel` (if "Node" is a core architectural term) or `CBaseInputViewModel`.
---
## Deconstructing Legacy Debt
### Case Study: `DsConfigEditorMainVm.cs`
This name suffers from **Context Overflow**:
1. **`Ds`**: Cryptic abbreviation. Move this logic to the **Namespace**.
2. **`ConfigEditor`**: Redundant if the file is already inside the `ConfigEditor` folder.
3. **`Main`**: A vague qualifier that adds little value.
4. **`Vm`**: Expand to `ViewModel` for professional clarity.
**Refactored Alternative:** `ConfigurationViewModel.cs`
---
## Modern C# Tools for Clean Code
Leverage **C# 10+** features to reduce visual noise:
- **File-scoped Namespaces:** `namespace SpectreFlow.ViewModels.Nodes;` (Removes indentation, providing more horizontal room for descriptive names).
- **Global Usings:** Define `global using com.dimins.modules.cbase;` once to keep individual files clean.
- **Target-typed New:** `CBaseInputViewModel vm = new();`
---
## The Golden Formula
### `[Brand] + [Feature] + [Role]`
- **Namespace = Geography:** Tells you _where_ the file lives.
- **Class Name = Identity:** Tells you _what_ the object is and _how_ it behaves.
> **Goal:** A developer should understand the object's purpose just by looking at the class name, without needing the context of the folder or using directives.