using Microsoft.Extensions.DependencyInjection;
using ODP.SintaxError.Sample.Contexts;
using ODP.SintaxError.Sample.Entities;

var services = new ServiceCollection();
services.AddDbContext<ApplicationContext>();
var serviceProvider = services.BuildServiceProvider();

using var scope = serviceProvider.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();

var process = dbContext.Set<Process>()
    .FirstOrDefault(x => x.Id.Equals("05688JX9Z0000") && x.Parts.Any());

Console.WriteLine($"Process: {process?.Id}");