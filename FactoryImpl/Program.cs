// See https://aka.ms/new-console-template for more information
using FactoryImpl.Interfaces;
using FactoryImpl.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args).ConfigureServices((_, services) =>
{
    services.AddTransient<IVehicle, Car>();
    services.AddTransient<IVehicle, Van>();
    services.AddTransient<IPickMeService, PickMeService>();
    services.AddSingleton<Func<IEnumerable<IVehicle>>>(x => () => x.GetService<IEnumerable<IVehicle>>()!);
    services.AddSingleton<IVehicleFactory, VehicleFactory>();

}).Build();


var entryPoint = host.Services.GetRequiredService<IPickMeService>();


entryPoint.GetDetails();