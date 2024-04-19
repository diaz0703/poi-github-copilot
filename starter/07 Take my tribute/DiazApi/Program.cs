var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var _us = new Usuarios();

app.MapGet("/", () => "Hello World!");

app.MapGet("/GetUsers", () => _us.GetUsuarios() );
app.MapGet("/GetUser", (int id) => _us.GetUsuario(id)    );
app.MapPost("/InsertaUsuario", (Usuario user) => _us.InsertarUsuario(user) );

app.Run();
