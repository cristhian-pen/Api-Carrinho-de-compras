
using CarrinhoComprasAPI.Data;
using CarrinhoComprasAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//string connection = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<Db>();

builder.Services.AddScoped<IClientes, ClienteServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
