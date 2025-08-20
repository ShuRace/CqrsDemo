# CqrsDemo

An ASP.NET Core Web API project demonstrating the CQRS pattern using MediatR and Entity Framework Core.

## Setup
1. Clone the repository: `git clone https://github.com/your-username/CqrsDemo.git`
2. Install dependencies: `dotnet restore`
3. Update the connection string in `appsettings.json`.
4. Run migrations: `dotnet ef database update`
5. Run the project: `dotnet run`

## Endpoints
- `POST /api/orders`: Create a new order.
- `GET /api/orders/{id}`: Retrieve an order by ID.

## Structure
- `Models/`: Domain models.
- `Features/`: CQRS commands and queries.
- `Data/`: Entity Framework Core context.
- `Controllers/`: API endpoints.