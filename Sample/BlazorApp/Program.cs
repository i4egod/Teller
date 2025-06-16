using BlazorApp.Services;
using BlazorApp.Components;
using Refit;
using Teller.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddScoped<IEnrollmentProvider>();
builder.Services.AddScoped<SecureHttpClientHandler>();
builder.Services.AddRefitClient<ITellerClient>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(ITellerClient.BaseAddress))
    .ConfigurePrimaryHttpMessageHandler<SecureHttpClientHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();