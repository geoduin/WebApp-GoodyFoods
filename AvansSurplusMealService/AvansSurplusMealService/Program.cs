using Core.DomainServices.Core.DomainService.Intf;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.Impl.DServices;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Core.DomainServices.Core.Intf;
using Infra.DatabaseConfiguration_EF_AvansSurplusMealService.IF_Logic;
using Core.DomainServices.Core.DomainServices.Logic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//-|| Regular database
string SurplusDB = builder.Configuration.GetConnectionString("SurplusDB");
//-|| Regular database || Configuration
builder.Services.AddDbContext<SurplusDatabaseContext>(options => options.UseSqlServer(SurplusDB));

//-|| Identity database
string Security = builder.Configuration.GetConnectionString("SecurityDB");

//-|| Identity || Configuration
builder.Services.AddDbContext<SecurityDBContext>(options => options.UseSqlServer(Security));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(config =>
{
    //Configures password requirements
    config.Password.RequiredLength = 8;
    config.Password.RequireNonAlphanumeric = false;
    config.Password.RequireDigit = true;
    config.Password.RequireLowercase = true;
    config.Password.RequiredUniqueChars = 2;
})
    .AddEntityFrameworkStores<SecurityDBContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.Cookie.Name = "PizzaEter";
    config.LoginPath = "/Account/Login";
});

builder.Services.AddAuthorization(config =>
{
    var AuthBuilder = new AuthorizationPolicyBuilder();
    var PolicyBuild = AuthBuilder.RequireAuthenticatedUser().Build();

    config.AddPolicy("LoggedUsers", policy => policy.RequireAuthenticatedUser());
    config.AddPolicy("PersonelOnly", policy => policy.RequireAuthenticatedUser().RequireClaim("CharacterRole", "Personel", "Admin"));
    config.AddPolicy("AdminOnly", policy => policy.RequireAuthenticatedUser().RequireClaim("CharacterRole", "Admin"));
});
//Dependency injection container
builder.Services.AddScoped<IStudentRepo, StudentRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IMealPacketRepo, SurplusMealRepo>();
builder.Services.AddScoped<IRoleFactory, Roles>();
builder.Services.AddScoped<IDomainFactory, DomainFactory>();
builder.Services.AddScoped<IPersonelRepo, PersonelRepo>();
builder.Services.AddScoped<IMealPacketService, MealPacketService>();
builder.Services.AddScoped<ICantineRepo, CantineRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=StartPagina}/{id?}");

app.MapControllerRoute(
    name: "OwnProfile",
    pattern: "Profile/Profile_Reservation/{Email}",
    defaults: new {controller = "Profile", action = "ProfileReservations" }
    );

app.Run();
