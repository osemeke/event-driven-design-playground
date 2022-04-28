using Data.Repositories.Interface;
using Data.Repositories;
using DelegatesConsoleApp;
using Data.Models;

var servicepoints = new MockServicePointRepository();
var displayscreens = new MockDisplayScreenRepository();

var displayscreen1 = await displayscreens.GetDisplayScreen("1");
var displayscreen2 = await displayscreens.GetDisplayScreen("2");
var servicePoint = await servicepoints.GetServicePoint("1");

Console.WriteLine($"\n================GET & CALL STUFF FROM REPO====================");

Console.WriteLine($"Service Point: {servicePoint.Name}");

var message = "next person please...";
servicePoint.Send(message);

Console.WriteLine($"\n================SIMPLE DELEGATE IMPLEMENTATION====================");

var simpleDelegateExample = new SimpleDelegateExample();
simpleDelegateExample.Run();

Console.WriteLine($"\n================FAKING EVENT BUS DELEGATE IMPLEMENTATION====================");

var bus = new EventBus(servicePoint);
// GetSubscribedScreens(servicePoint.Id); and do a foreach
bus.Subscribe(displayscreen1);
bus.Subscribe(displayscreen2);
bus.Send(message); // indirect call

Console.WriteLine($"\n================FAKING GENERIC EVENT BUS DELEGATE IMPLEMENTATION====================");

var genericbus = new GenericEventBus<ServicePoint,DisplayScreen>(servicePoint);
// GetSubscribedScreens(servicePoint.Id); and do a foreach
genericbus.Subscribe(displayscreen1);
genericbus.Subscribe(displayscreen2);
genericbus.Send(message); // indirect call

Console.WriteLine($"\n================FAKING EVENT BUS EVENTHANDLER IMPLEMENTATION====================");

var eventbus = new EventHandlerEventBus(servicePoint);
// GetSubscribedScreens(servicePoint.Id); and do a foreach
eventbus.Subscribe(displayscreen1);
eventbus.Subscribe(displayscreen2);
eventbus.Send(message); // indirect call


