using Microsoft.EntityFrameworkCore;
using NutriConsultoriaAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Adicionando o contexto do banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicionando os controladores
builder.Services.AddControllers().AddNewtonsoftJson();

// Configuração Swagger para documentação da API (opcional)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
