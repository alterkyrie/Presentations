# Presentations Repository

Welcome to the Presentations repository. This collection contains educational materials, slide decks, and code examples for various technical topics, primarily focused on C# and software architecture.

## 📚 Topics Covered

### 🏷️ C# Naming & Architecture: From Legacy to Clarity
A deep dive into clean code principles, naming conventions, and architectural best practices in the context of C# development.
- **Location**: [`/naming`](./naming/)
- **Main Content**: [`naming_presentation.md`](./naming/naming_presentation.md) (Marp-ready Markdown)
- **Key Takeaways**:
  - Avoiding minimalist and cryptic naming.
  - The importance of namespace philosophy.
  - Lifecycle-based class naming (e.g., MVVM suffixes).
  - Leveraging modern C# features for cleaner code.

### 🧵 Multi-Threading & Asynchronous Programming
A comprehensive look at threading models, async/await patterns, and concurrency in C#.
- **Location**: [`/threading`](./threading/)
- **Main Presentation**: [`MultiThreading.pdf`](./threading/MultiThreading.pdf)
- **Code Examples**:
  - `1AsyncExample.cs`: Basic async/await usage.
  - `2WinformsAsyncBug.cs`: Common pitfalls in UI-based async code.
  - `Eventloop.cs`: Understanding the event loop mechanism.
  - `7CanceletionToken.cs`: Implementing graceful cancellation.
  - `8Concurent.cs`: Working with concurrent collections.

## 🚀 Getting Started

Most presentations are provided as either PDF files or Markdown files compatible with [Marp](https://marp.app/).

1.  **Markdown Presentations**: Open the `.md` files in VS Code with the Marp extension for the best viewing experience.
2.  **Code Examples**: The `/threading` directory contains a C# project (`presentation2.csproj`) that you can open in Visual Studio or JetBrains Rider to run the examples.

---

**Author**: Anatolii Pastushuk
