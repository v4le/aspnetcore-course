using DemoApp.Pages.Contatti;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


if (builder.Environment.IsDevelopment()) // ambiente di sviluppo
{
    builder.Services.AddSingleton<IContattiService, InMemoryContattiService>();
}
else
{
    builder.Services.AddSingleton<IContattiService>(provider =>
    {
        var configuration = provider.GetService<IConfiguration>();
        var connectionString = configuration["ConnectionStrings:MyConnectionString"];

        return new ContattiService(connectionString);
    });
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
