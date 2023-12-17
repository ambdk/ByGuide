using ByGuide.Service;
using TuristInfoV1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IPostService, PostService>();
builder.Services.AddSingleton<ITuristService, TuristService>();
builder.Services.AddSingleton<IEventService, EventService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

bool isTrue = true;
bool isFalse = false;

if (isTrue)
{
	Console.WriteLine("HanidcapAccesible, true.");
}
else
{
	Console.WriteLine("HanidcapAccesible, false.");
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
