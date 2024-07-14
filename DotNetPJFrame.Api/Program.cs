using DotNetPJFrame.Api.Features.Gate;
using DotNetPJFrame.Modules.Features;
using DotNetPJFrame.Modules.Features.Test;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<MainApiGate>();

#region MerchantApi,Gate

builder.Services.AddScoped<ApiGate>();
builder.Services.AddScoped<Api>();
#endregion

#region BL

builder.Services.AddScoped<BL_Test>();

#endregion

#region DA

builder.Services.AddScoped<DA_Test>();

#endregion

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
