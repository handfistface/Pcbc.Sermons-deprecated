using Pcbc.Domain.Builders;
using Pcbc.Domain.Factories;
using Pcbc.Domain.ViewModels;
using System.Web.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBuilder<SermonsViewModel>, SermonsViewModelBuilder>();
builder.Services.AddScoped<ISermonSeriesViewModelBuilder, SermonSeriesViewModelBuilder>();
builder.Services.AddScoped<IAudioFileViewModelBuilder, AudioFileViewModelBuilder>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
