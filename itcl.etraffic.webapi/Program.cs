using itcl.etraffic.infrastructure.ServiceDependancy;
using itcl.etraffic.persistance.DataConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DMPDBContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins(
            "http://localhost:5173",    // Vite dev server
            "http://192.168.0.102:5173" // optional if accessing via LAN IP
        )
          .AllowAnyHeader()
          .AllowAnyMethod()
          .AllowCredentials()
          .WithExposedHeaders("Content-Disposition");
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ITCL E-Traffic System",
        Version = "2.0",
        Description = "Official ITCL E-Traffic Web API"
    });
});

builder.Services.InjectService();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseRouting();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ITCL E-triffic System");
    c.RoutePrefix = "swagger"; // Access at https://<host>/swagger
    c.DocumentTitle = "ITCL E-Traffic API Docs";
});
app.UseCors("AllowFrontend");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
