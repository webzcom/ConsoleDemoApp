using ConsoleDemo;
using DemoBL;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    //Add your service here
    .AddSingleton<IDemoService, DemoService>()
    .AddSingleton<InternalService>()
    .BuildServiceProvider();

var demoService = serviceProvider.GetRequiredService<IDemoService>();
var internalService = serviceProvider.GetRequiredService<InternalService>();

demoService.SayHello();
internalService.SayHello();
