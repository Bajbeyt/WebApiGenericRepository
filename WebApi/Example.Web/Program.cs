using Example.Web.Extensions;
using Presantations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureSQLContext(builder.Configuration);
builder.Services.ConfigerRepositoryMananger();
builder.Services.AddControllers()
    .AddApplicationPart(typeof(Presantations.AssemblyReferenge).Assembly);
builder.Services.ConfigureServiceMananger();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();

