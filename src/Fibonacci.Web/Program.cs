using Fibonacci;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

using var fibonacciDataContext = new FibonacciDataContext();

app.MapGet("/Fibonacci", 
    async () => await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(new []{"44", "43"}));
app.MapGet("/Fibonacci2", 
    async () => await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(new []{"44", "43"}));

app.Run();
