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
/BookingApp.API
│   ├── Controllers
│   ├── Middleware (Auth, Logging, ErrorHandling)
│   └── Program.cs / DI

/BookingApp.Application
│   ├── DTOs
│   ├── Interfaces (e.g. IServiceRepository)
│   ├── Validators (FluentValidation)
│   ├── Services (CommandHandlers, QueryHandlers)
│   └── Features (Booking, Payment, etc.)

/BookingApp.Domain
│   ├── Entities (Booking, User, Payment)
│   ├── Enums
│   ├── Interfaces (IRepository, IDomainEvent)
│   └── ValueObjects

/BookingApp.Infrastructure
│   ├── Data (DbContext, migrations)
│   ├── Repositories
│   ├── ExternalServices (Email, Redis, etc.)
│   └── Configuration (EF config, connection strings)
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
