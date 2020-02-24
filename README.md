# e-businessSystem
- Sample microservices project using grpc & aspnet core 3x

## Checklist to complete.

- Basic struct :heavy_check_mark:
- Business logics :x:
- Unit Tests :x:
- Func Tests :x:
- BuildingBlocks: MongoDb :x:
- BuildingBlocks: MessageBus :x:
- Bff Swaggers :x:
- Auth :x:
- Dockerfiles :heavy_check_mark:
- K8s Files :heavy_check_mark:
- CI / CD :x:
- Pipelines :x:

## Technologies implemented:

- ASP.NET Core 3.1 (with .NET Core 3.1)
- MongoDb
- .NET Core Native DI
- FluentValidator for input validations.
- Swagger documentation for external communication  
- Cache distributed with redis
- Container with docker
- Container orchestration with K8s
- Internal comunication with gRPC
- External comunication with Rest
- Bff pattern to expose external comunication (Backend for Front)
- MessageBus with rabbitMq

## Microservice architecture objective:

- Full architecture with responsibility separation concerns, SOLID and Clean Code
- Domain Driven Design (Layers and Domain Model Pattern)
- Domain Events
- Domain Notification
- Event Sourcing
- Unit of Work
- Repository and Generic Repository
