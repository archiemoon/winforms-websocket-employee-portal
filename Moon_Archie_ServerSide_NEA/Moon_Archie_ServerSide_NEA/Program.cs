// Creates a web app builder which we will use as our server interface 
var builder = WebApplication.CreateBuilder(args);

// adds the signalR library to the web application
builder.Services.AddSignalR();

var app = builder.Build();

// otherwise to the /Home/Error extension
app.UseExceptionHandler("/Home/Error");
app.UseHsts();


// This endpoint is what users will connect to for communication
app.MapHub<ChatHub>("/chatHub");

// writes connected upon the initial request to the server proving its connected
app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Connected");
});

app.Run();
