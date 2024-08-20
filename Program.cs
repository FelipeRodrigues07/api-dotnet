var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRouting(option => option.LowercaseUrls = true);


//builder.Configuration.GetSection("Logging").GetSection("LogLevel") //pegar informações do app settings
var teste = builder.Configuration.GetSection("PropA").Value;



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) //so mostra em desenvolvimento
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); //mapeamento dos controles

app.Run();


//arquivo principal - main