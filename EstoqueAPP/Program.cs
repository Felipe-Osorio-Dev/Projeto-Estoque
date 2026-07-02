using EstoqueAPP.Presenters.Main;
using EstoqueAPP.Services.Navigation;
using EstoqueAPP.Views.Main;
using EstoqueAPP.Views.Register;
using Microsoft.Extensions.DependencyInjection;

namespace EstoqueAPP
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (var scope = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                var mainContainer = scope.GetRequiredService<MainForm>();
                scope.GetRequiredService<MainPresenter>();

                Application.Run(mainContainer);
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            //Main Container
            services.AddSingleton<MainForm>();

            //Forms
            services.AddTransient<RegisterForm>();

            //Presenters
            services.AddTransient<MainPresenter>();
            
            //Interfaces
            services.AddTransient<IMainView>(sp => sp.GetRequiredService<MainForm>());

            //Services
            services.AddSingleton<INavigationService, NavigationService>();
        }
    }
}