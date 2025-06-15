# BookingApp

A clean architecture-based ASP.NET Core Web API for managing bookings, users, and payments.

## 📦 Tech Stack

- ✅ ASP.NET Core 8 Web API
- ✅ Entity Framework Core
- ✅ SQL Server
- ✅ MediatR (CQRS)
- ✅ FluentValidation
- ✅ Clean Architecture
- ✅ Serilog (logging)
- ✅ JWT Authentication

## 📁 Project Structure

```

BookStoreManagement/
│
├── bsm.API/                  ← Startup & cấu hình app
│   └── Program.cs
│
├── bsm.Presentation/            ← Controllers, Filters, Middleware
│   ├── Controllers/
│   ├── Middleware/
│   └── DependencyInjection.cs
│
├── bsm.Application/             ← Use Cases, Logic trung gian
│   ├── Commands/
│   ├── Queries/
│   ├── DTOs/
│   └── DependencyInjection.cs
│
├── bsm.Domain/                  ← Business Core (Entities, Rules)
│   ├── Entities/
│   ├── Interfaces/
│   ├── Enums/
│   └── Exceptions/
│
├── bsm.Infrastructure/         ← Data access & services bên ngoài
│   ├── Persistence/
│   ├── Repositories/
│   └── DependencyInjection.cs
│
└── BookStoreManagement.sln      ← Solution file


```

## 🚀 Getting Started

### 🔧 Prerequisites

- [.NET SDK 8+](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### 🛠️ Setup

```bash
# Clone repository
git clone https://github.com/tieuhung-dev/BookingApp.git
cd BookingApp

# Update connection string in appsettings.json

# Apply migrations
dotnet ef database update --project BookingApp.Infrastructure --startup-project BookingApp.API

# Run the app
dotnet run --project BookingApp.API
```

## 📬 API Endpoints

Will be documented soon using Swagger.

## 🙌 Author

- [@tieuhung23](https://github.com/TieHung23)
