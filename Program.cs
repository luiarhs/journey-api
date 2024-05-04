using JourneyAPI.Services;

var builder = WebApplication.CreateSlimBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<TrafficLightService>();
builder.Services.AddHostedService<TrafficLightBackgroundService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/trafficlights", (TrafficLightService trafficLightService) =>
{
    return Results.Ok(trafficLightService.RetrieveLights());
}).WithName("GetTrafficLights")
.WithOpenApi(); ;

app.Run();
