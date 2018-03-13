using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.OData.Extensions;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Builder;
using Microsoft.IdentityModel.Tokens;

using Agriculturapp.Data;
using Agriculturapp.Models;
using Agriculturapp.Authentication;

namespace Agriculturapp
{
  public partial class Startup
  {
    private static void DotEnv([CallerFilePath] string path = "")
    {
      var dotEnv = Path.Combine(Path.GetDirectoryName(path), "..", ".env");

      if (File.Exists(dotEnv))
      {
        var dotenv = File.ReadAllText(dotEnv).Trim();
        var lines = dotenv.Split('\n');

        foreach (var line in lines)
        {
          var index = line.IndexOf("=");

          var key = line.Substring(0, index);

          var value = line.Substring(index + 1);

          Environment.SetEnvironmentVariable(key, value.TrimStart('"').TrimEnd('"'));
        }
      }
    }

    public Startup(IHostingEnvironment env)
    {
      Startup.DotEnv();

      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        .AddEnvironmentVariables();

      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    partial void OnConfigureServices(IServiceCollection services);

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddOptions();
      services.AddCors();

      services.AddMvc();
      services.AddAuthorization();
      services.AddOData();

      services.AddDbContext<ApplicationIdentityDbContext>(options =>
      {
          options.UseNpgsql(Configuration.GetConnectionString("AgriculturebdConnection"));
      });

      services.AddIdentity<ApplicationUser, IdentityRole>()
              .AddEntityFrameworkStores<ApplicationIdentityDbContext>();

      services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationPrincipalFactory>();


      services.AddDbContext<AgriculturebdContext>(options =>
      {
        options.UseNpgsql(Configuration.GetConnectionString("AgriculturebdConnection"));
      });

      OnConfigureServices(services);
    }

    partial void OnConfigure(IApplicationBuilder app);

    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddConsole(Configuration.GetSection("Logging"));
      loggerFactory.AddDebug();

      var provider = app.ApplicationServices.GetRequiredService<IAssemblyProvider>();

      app.UseCors(builder =>
        builder.WithOrigins("*")
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials()
               .AllowAnyOrigin()
      );

      var tokenValidationParameters = new TokenValidationParameters
      {
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = TokenProviderOptions.Key,
          ValidateIssuer = true,
          ValidIssuer = TokenProviderOptions.Issuer,
          ValidateAudience = true,
          ValidAudience = TokenProviderOptions.Audience,
          ValidateLifetime = true,
          ClockSkew = TimeSpan.Zero
      };

      var options = new JwtBearerOptions
      {
          AutomaticAuthenticate = true,
          AutomaticChallenge = true,
          TokenValidationParameters = tokenValidationParameters
      };

      app.UseJwtBearerAuthentication(options);

      app.Use(async (context, next) => {
          try
          {
              await next();
          }
#pragma warning disable 0168
          catch (Microsoft.AspNetCore.Mvc.Internal.AmbiguousActionException ex) {
#pragma warning restore 0168
              if (!Path.HasExtension(context.Request.Path.Value)) {
                  context.Request.Path = "/index.html";
                  await next();
              }
          }

          if ((context.Response.StatusCode == 404 || context.Response.StatusCode == 401) && !Path.HasExtension(context.Request.Path.Value)) {
              context.Request.Path = "/index.html";
              await next();
          }
      });

      app.UseDefaultFiles();
      app.UseStaticFiles();

      app.UseDeveloperExceptionPage();

      app.UseMvc(builder =>
      {
          if (env.EnvironmentName == "Development")
          {
              builder.MapRoute(name: "default",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Home", action = "Index" }
              );
          }
        var agriculturebdBuilder = new ODataConventionModelBuilder(provider);
        agriculturebdBuilder.ContainerName = "AgriculturebdContext";

        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Calidad>("Calidads");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.CategoriaInsumo>("CategoriaInsumos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Categorium>("Categoria");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Ciudad>("Ciudads");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Compra>("Compras");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.ComprasPago>("ComprasPagos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.ControlPlaga>("ControlPlagas");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Cultivo>("Cultivos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Departamento>("Departamentos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.DetalleCategoriaInsumo>("DetalleCategoriaInsumos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.DetalleCompra>("DetalleCompras");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.DetalleMetodopago>("DetalleMetodopagos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.DetalleOfertum>("DetalleOferta");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.DetalleTipoProducto>("DetalleTipoProductos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Enfermedade>("Enfermedades");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Equipo>("Equipos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Foto>("Fotos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Insumo>("Insumos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Laboratorio>("Laboratorios");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.LocalizacionUp>("LocalizacionUps");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Lote>("Lotes");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.MetodoPago>("MetodoPagos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Notificacione>("Notificaciones");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Oferta>("Oferta");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Pago>("Pagos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Produccion>("Produccions");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.ProductCategorium>("ProductCategoria");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Producto>("Productos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Recetum>("Receta");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Rol>("Rols");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.TipoInsumo>("TipoInsumos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.TipoProducto>("TipoProductos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Tratamiento>("Tratamientos");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.TypeNotification>("TypeNotifications");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.UnidadMedida>("UnidadMedidas");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.UnidadProductiva>("UnidadProductivas");
        agriculturebdBuilder.EntitySet<Agriculturapp.Models.Agriculturebd.Usuario>("Usuarios");

        builder.MapODataRoute("odata/agriculturebd", agriculturebdBuilder.GetEdmModel());
        var identityBuilder = new ODataConventionModelBuilder(provider);
        identityBuilder.ContainerName = "ApplicationIdentityDbContext";
        identityBuilder.EntitySet<ApplicationUser>("ApplicationUsers");
        var usersType = identityBuilder.StructuralTypes.First(x => x.ClrType == typeof(ApplicationUser));
        usersType.AddCollectionProperty(typeof(ApplicationUser).GetProperty("RoleNames"));
        identityBuilder.EntitySet<IdentityRole>("ApplicationRoles");

        builder.MapODataRoute("auth", identityBuilder.GetEdmModel());
      });

      var identityDbContext = app.ApplicationServices.GetRequiredService<ApplicationIdentityDbContext>();

      identityDbContext.Database.Migrate();

      OnConfigure(app);
    }
  }
}
