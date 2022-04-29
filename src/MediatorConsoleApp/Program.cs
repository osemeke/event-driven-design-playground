using MediatorConsoleApp.Data;
using MediatorConsoleApp.Mediator;

var servicepoints = new ServicePointRepository();
var displayscreens = new DisplayScreenRepository();

var displayScreen1 = await displayscreens.GetDisplayScreen("1");
var displayScreen2 = await displayscreens.GetDisplayScreen("2");
var servicePoint = await servicepoints.GetServicePoint("1");

Console.WriteLine($"\n================GET & CALL STUFF FROM REPO====================");
Console.WriteLine($"Service Point: {servicePoint.Name}");

Console.WriteLine($"\n================GET & CALL STUFF VIA THE MEDIATOR====================");

var message = "next person please...";

IMediator _mediator = new ServiceBusMediator();
// get subscribers to call_in_next event from db
_mediator.Subscribe(new EventSubscription { Event = "call_in_next", Subscriber = displayScreen1 });
_mediator.Subscribe(new EventSubscription { Event = "call_in_next", Subscriber = displayScreen2 });
_mediator.Publish("call_in_next", message); // can be Notify() or Send() or Dispatch()
                                        // can come from a message brocker

