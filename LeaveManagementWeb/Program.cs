using Humanizer;
using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

/*  1. We extend the AspNetUsers table which is a table created when we use authentication type as induvidual authentication
    2. The name of the extended table is Employee table. So we need to create an Employee class and then inherit IdentityUser class, which is part of Microsoft.AspNetCore.Identity
    3. Now since we want AspNetUsers to have additional coloumns present in Employee class, we need to extend the Employee class in ApplicationDbContext : IdentityDbContext<Employee>
    4. Now we need to make changes in the program.cs. We need to change AddDefaultIdentity<IdentityUser> to AddDefaultIdentity<Employee>. Now add-migration and update-database
    5. Now we need to add two tables, the leavetype table and LeaveAllocation table. Since these tables have common coloumns, we can create another class with the common coloumns
       and then inherit this class onto the LeaveType and LeaveAllocation class. Now add migra and update database
    
    
    asjkd*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
