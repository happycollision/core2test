using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using core2test.Models;
using JsonApiDotNetCore.Extensions;

namespace core2test
{
    public class Startup
    {       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PersonContext>(opt => opt.UseInMemoryDatabase("People"));
            services.AddMvc();
            services.AddJsonApi<PersonContext>(opt => 
            {
                opt.Namespace = "api";
            });
        }

        public async void Configure(IApplicationBuilder app, PersonContext context)
        {
            context.Database.EnsureCreated();
            if(await context.People.AnyAsync() == false) 
            {
                context.People.Add(new Person {
                    Name = "John Doe"
                });
                context.SaveChanges();
            }

            app.UseJsonApi();
        }
    }
}