# AcmeCorpShopperApp

This solution contains a full-stack ASP.NET Core application with a RESTful API backend and an MVC web frontend. It enables basic product management functionality using Entity Framework Core and Razor views.

---

## Technologies Used

- **Language**: C#
- **Frameworks**: ASP.NET Core Web API & ASP.NET Core MVC
- **Database**: Entity Framework Core with a data context
- **Frontend**: Razor Views (MVC)
- **Build Tool**: .NET SDK
- **IDE**: Visual Studio / Visual Studio Code

---

## Solution Structure

<pre> ```text AcmeCorpShopperApp.sln # Visual Studio solution file ├── AcmeCorp.Shopper.ProductsRestApi # Backend API (ASP.NET Core Web API) │ ├── Controllers/ │ │ └── ProductsController.cs # API endpoints for creating and reading products │ ├── Models/ │ │ └── ProductsAcmeContext.cs # EF Core DbContext for Product entity │ ├── appsettings.json # Configuration and DB setup │ └── Program.cs # Entry point for the Web API ├── AcmeCorp.Shopper.UiWebApp # Frontend MVC Web App (ASP.NET Core MVC) │ ├── Controllers/ │ │ ├── HomeController.cs │ │ └── LibraryController.cs # Interacts with the API │ ├── Models/ │ │ └── ErrorViewModel.cs │ ├── Views/ │ │ ├── Home/ │ │ │ └── Index.cshtml, Privacy.cshtml │ │ ├── Library/ │ │ │ └── AllProducts.cshtml # Product listing Razor view │ │ └── Shared/ # Shared layout, error, and partial views │ ├── wwwroot/ │ │ ├── css/ │ │ ├── js/ │ │ └── lib/ # Static assets (Bootstrap, jQuery, validation) │ └── Program.cs # Entry point for the MVC app ``` </pre>


---

## 🔧 Functionality Overview

### REST API (`AcmeCorp.Shopper.ProductsRestApi`)
- `POST /api/products` → Create a new product (using EF Core)
- `GET /api/products` → Get all products
- `GET /api/products/{id}` → Get a product by ID

### Frontend (`AcmeCorp.Shopper.UiWebApp`)
- Razor views for displaying content
- Shared layout and partial views
- Likely fetches product data to display in the UI (e.g., `AllProducts.cshtml`)

---

## Getting Started

### Prerequisites
- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- Visual Studio or VS Code

### Running the Application
1. Open the solution in Visual Studio (`AcmeCorpShopperApp.sln`)
2. Set both projects to run simultaneously if needed (API + UI)
3. Launch and navigate to the UI (`UiWebApp`) which may call the API internally

---

## Future Enhancements
- Add authentication and authorization
- Connect to a persistent SQL database
- Add client-side interactivity with JavaScript or a JS framework
- API documentation via Swagger

---

## Notes
- `ProductsAcmeContext` shows usage of Entity Framework Core for data persistence.
- Controller actions are lightweight and clean, following RESTful conventions.
