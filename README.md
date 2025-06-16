# [Teller.io](https://teller.io) .NET SDK

## Teller.Api

- **Purpose:**  
  A .NET 8 class library for interacting with the Teller API.
- **Features:**  
  - Provides strongly-typed API clients using [Refit](https://github.com/reactiveui/refit) for easy HTTP communication.
  - Handles authentication and secure HTTP requests.
  - Designed for use in server-side or backend .NET applications that need to access financial data via Teller.

## Teller.Connect

- **Purpose:**  
  A Blazor component library for connecting user bank accounts via Teller.
- **Features:**  
  - Integrates Teller’s Connect JavaScript widget into Blazor applications.
  - Enables users to securely link their bank accounts from the browser.
  - Can be easily embedded in any Blazor Server or WebAssembly project.

## Sample/BlazorApp

- **Purpose:**  
  A sample Blazor Server application demonstrating how to use both `Teller.Api` and `Teller.Connect` together.
- **Features:**  
  - Shows how to configure and use the Teller API client.
  - Demonstrates embedding the Teller Connect component in a real Blazor app.

## Getting Started

1. **Clone the repository and open in Visual Studio 2022 or later.**
2. **Restore NuGet packages and build the solution.**
3. **Run the sample Blazor app to see Teller integration in action.**

---

- All projects target .NET 8.
- The solution is ready for extension and integration into your own financial or banking applications.
