using ProWebAPIAroject.Context;
using ProWebAPIProject.Contracts;
using ProWebAPIProject.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container

builder.Services.AddControllers();
builder.Services.AddCors(options => { options.AddPolicy(name: "AllowOrigin", builder => { builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); }); });
//Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(
      options =>
      {

          var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
          var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
          options.IncludeXmlComments(filePath);
      });
builder.Services.AddSingleton<LibraryContext>();
builder.Services.AddScoped<ILibrary, LibraryServices>();
var app = builder.Build();


//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "API Project");

        }
    );
}

app.UseAuthorization();
app.UseCors("AllowOrigin");

app.MapControllers();

app.Run();
