var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app     = builder.Build();
var harbour = new RiverHarbour();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/info", () => harbour.GetBaseInfo()); 

app.MapGet("/boats", () => {
    Object response = harbour.GetAllBoats();
    return response is null 
        ? Results.NotFound() 
        : Results.Ok(response); 
}); 

app.MapGet("/boats/{id}", (int id) => {
    Object response = harbour.FindBoatById(id);
    return response is null 
        ? Results.NotFound() 
        : Results.Ok(response); 
}); 

app.MapPost("/boats/", (Boat boat) => {
    Object response = harbour.RegisterBoat(boat);
    return response is null 
        ? Results.Problem("Can't add an boat") 
        : Results.Ok(response); 
}); 

app.MapPut("/boats/{id}", (int id, Boat boat) => {
    Object response = harbour.UpdateBoatInfo(id, boat);
    return response is null 
        ? Results.NotFound() 
        : Results.Ok(); 
}); 

app.MapDelete("/boats/{id}", (int id) => {
    Object response = harbour.DeleteBoatInfo(id);
    return response is null 
        ? Results.NotFound() 
        : Results.Ok(); 
}); 

app.Run();
