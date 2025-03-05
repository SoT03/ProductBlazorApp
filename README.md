# ProductBlazorApp

**ProductBlazorApp** is a web application built using [Blazor](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro), a framework for creating interactive web UIs with C#. This application demonstrates the implementation of product management features, including listing products, viewing product details, and managing product data.

## Features

- **Product Listing**: Displays a list of products with relevant details.
- **Product Management**: Allows for the creation, updating, and deletion of products.
- **Api Calls**: Allows for POST and GET api calls.

## Getting Started

To run this application locally, follow these steps:

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/SoT03/ProductBlazorApp.git
   ```

2. **Navigate to the project directory**:

   ```bash
   cd ProductBlazorApp/ProductBlazorApp
   ```

3. **Restore dependencies**:

   ```bash
   dotnet restore
   ```

4. **Build the project**:

   ```bash
   dotnet build
   ```

5. **Run the application**:

   ```bash
   dotnet run
   ```

 

## Project Structure

The project is organized as follows:

- `Pages/`: Contains Razor components for different pages, such as `Index.razor`, `ProductList.razor`, and `ProductDetail.razor`.
- `Program.cs`: The entry point of the application.
- `Models`: Contains models for Post and Product.
- `Services`: Contains Api and product service.
- `Data`: Contains Context for product to communicate with Database.


## Acknowledgements

- [Blazor Tutorial | Build your first app](https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro)
- [Building a Task Management App with Blazor and Entity Framework Core](https://www.bomberbot.com/web-development/building-a-task-management-app-with-blazor-and-entity-framework-core/)
- [Build web apps with ASP.NET Core for beginners](https://learn.microsoft.com/en-us/training/paths/aspnet-core-web-app/)

These resources provided valuable insights and guidance during the development of this application.

