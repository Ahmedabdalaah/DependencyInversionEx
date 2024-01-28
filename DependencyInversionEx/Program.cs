// See https://aka.ms/new-console-template for more information
using DependencyInversionEx;

Notification notification = new Notification(new SMS());
notification.SendNotification();
Notification notification2 = new Notification(new Email());
notification.SendNotification();
Console.ReadKey();