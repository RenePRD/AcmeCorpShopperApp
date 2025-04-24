# AcmeCorp Shopper Application

This repository contains a full-stack shopping cart application built using **C#** and **ASP.NET Core**. It demonstrates a modular architecture with separate projects for the backend REST API and the frontend web application. The project showcases skills in web development, API design, and database integration.

## Overview

The AcmeCorp Shopper Application is a shopping cart system designed to manage products and provide a user-friendly interface for customers. It consists of two main components:

1. **Products REST API** (`AcmeCorp.Shopper.ProductsRestApi`):
   - A backend service built with **ASP.NET Core** and **Entity Framework Core**.
   - Provides CRUD operations for managing products.
   - Exposes RESTful endpoints for integration with other services or applications.
   - Includes **Swagger/OpenAPI** for API documentation and testing.
   - Uses **SQL Server** as the database, with a connection managed via Entity Framework.

2. **UI Web Application** (`AcmeCorp.Shopper.UiWebApp`):
   - A frontend web application built with **ASP.NET Core MVC**.
   - Implements a responsive user interface using **Bootstrap**.
   - Displays product information fetched from the REST API.
   - Includes server-side rendering with Razor views.
   - Demonstrates client-side validation using **jQuery Validation** and **Unobtrusive Validation**.

## Features

- **Backend (ProductsRestApi)**:
  - Create, read, update, and delete products.
  - Query products by ID or name.
  - Database integration with **Entity Framework Core**.
  - API documentation via **Swagger UI**.

- **Frontend (UiWebApp)**:
  - Displays a list of products with details like ID, name, and price.
  - Navigation and layout built with **Bootstrap**.
  - Razor views for dynamic content rendering.
  - Error handling and validation for user input.

## Technologies Used

- **Languages**: C#
- **Frameworks**: ASP.NET Core, Entity Framework Core
- **Frontend**: Bootstrap, jQuery, Razor Views
- **Database**: SQL Server
- **Tools**: Swagger/OpenAPI, Visual Studio


