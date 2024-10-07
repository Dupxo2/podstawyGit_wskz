var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    Console.WriteLine("Ponowny test zmiany");
    Console.WriteLine("Test wysy³ania zmian");
    Console.WriteLine("Test wysy³ania zmian VS wersja 2");
    Console.WriteLine("Test wysy³ania zmian VS wersja 3");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
