// See https://aka.ms/new-console-template for more information

using FacadePattern;

SubSystem subsystem1 = new SubSystem();
SubSystem2 subsystem2 = new SubSystem2();
Facade facade = new Facade(subsystem1, subsystem2);
Client.Main(facade);
