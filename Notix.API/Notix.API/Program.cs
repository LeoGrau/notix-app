using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Notix.API.Notes.Domain.Models;
using Notix.API.Notes.Domain.Repositories;
using Notix.API.Notes.Domain.Services;
using Notix.API.Notes.Mappers;
using Notix.API.Notes.Repositories;
using Notix.API.Notes.Services;
using Notix.API.Shared.Domain.Repositories;
using Notix.API.Shared.Persistence;
using Notix.API.Shared.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// Add Controllers
builder.Services.AddEndpointsApiExplorer();
// Open API Configuration
builder.Services.AddSwaggerGen(
    options =>
    {
        options.SwaggerDoc("v0", new OpenApiInfo
        {
            Version="v0",
            Title = "Notix.API",
            Description = "Notix.API v0"
        });
        options.EnableAnnotations();
    }
);

// Connection String
var connectionString = builder.Configuration.GetConnectionString("NotixDBConnection");

// Add DB Context
builder.Services.AddDbContext<AppDbContext>(optionsBuilder =>
{
    if (connectionString != null)
    {
        optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)))
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    }
});

// Routing
builder.Services.AddRouting(options => options.LowercaseUrls = true);
// CORS
builder.Services.AddCors();
// Add Authorization
builder.Services.AddAuthorization();

// Services

// Notes
// -- Notes --
builder.Services.AddScoped<INoteRepository, NoteRepository>();
builder.Services.AddScoped<IBaseRepository<Note, long>, BaseRepository<Note, long>>();
builder.Services.AddScoped<INoteService, NoteService>();

// Shared
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Automapper
builder.Services.AddAutoMapper(
    typeof(ResourceToModelProfile),
    typeof(ModelToResourceProfile));

var app = builder.Build();

// Validation for ensuring database tables were created.
using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<AppDbContext>())
{
    // context?.Database.EnsureCreated();
    context?.Database.EnsureDeleted();
    context?.Database.EnsureCreated();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("v0/swagger.json", "v0");
        options.RoutePrefix = "swagger";
    });
}


app.UseCors(policyBuilder => policyBuilder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
