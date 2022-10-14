using Stripe;
using StripeWebApiExample.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<ChargeService>();
StripeConfiguration.ApiKey = builder.Configuration.GetValue<string>("StripeOptions:SecretKey");

builder.Services.AddScoped<IStripeService, StripeService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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