# Event Driven Design Playground
How to use different technologies to achieve a event publish subscriber system 

## Leverage on the following technologies
- Delegates
- Events
- Mediator Design Pattern
- Event Bus
- CQRS using MediatR
- Docker Containers
- RabbitMQ
- CQRS with RabbitMQ
- SignalR
- Background Service
- WebRTC
- Data Streaming
- Event Brokers/ Stores Interface like RabbitMQ/ Kafka/ Redis
	
## CQRS using MediatR guide

### Step by step

- install swagger
- install mediatr
- create classes for __entities__ > __repositories__
- create classes for dto __models__ like `CarResponseModel` and `CarRequestModel`
- add `using MediatR;` on top of files from here on
- create classes for __requests__ like `GetCarsQuery` and `CreateCarCommand`, then extend `IRequest<TResponse>` where `TResponse` is response object type
- create classes for __handlers__ like `GetCarsQueryHandler` and `CreateCarCommandHandler`, then extend `IRequestHandler<IRequest,TResponse>`
- example for the above will be `GetCarsQuery : IRequest<CarResponseModel>` and `CreateCarCommandHandler : IRequestHandler<GetCarsQuery,CarResponseModel>`. Note that `CarResponseModel` can be `int`, `bool`, `string` etc
- In `Program.cs` add `builder.Services.AddMediatR(typeof(Program).GetTypeInfo().Assembly);` to reqister MediatR in DI container
- In the controler add `private IMediator _mediator;`
- write controller action

### Observaations 

- `Query` and `Command` are refered to as `Request` in MediatR
- `Event` is refered to as `Notification` in MediatR 
- A `Request` should be immutable so the setter property removed i.e `{ get; }`
- Request pipeline: Controller > Query or Command `Tresponse` > Handler `Trequest,Tresponse` > Repository. Here Trequest is the Query/Command type.

### Nuget Packages

	dotnet add package MediatR --version 10.0.1
	dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 10.0.1




