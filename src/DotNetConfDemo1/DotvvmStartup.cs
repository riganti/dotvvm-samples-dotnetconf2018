using DotVVM.Framework.Configuration;
using DotVVM.Framework.Controls.Bootstrap;
using DotVVM.Framework.ResourceManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetConfDemo1
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        // For more information about this class, visit https://dotvvm.com/docs/tutorials/basics-project-structure
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config, applicationPath);
            ConfigureControls(config, applicationPath);
            ConfigureResources(config, applicationPath);

            config.AddBootstrapConfiguration(new DotvvmBootstrapOptions()
            {
                JQueryUrl = "~/lib/jquery/dist/jquery.slim.min.js",
                BootstrapCssUrl = "~/lib/bootstrap/dist/css/bootstrap.min.css",
                BootstrapJsUrl = "~/lib/bootstrap/dist/js/bootstrap.min.js"
            });
        }

        private void ConfigureRoutes(DotvvmConfiguration config, string applicationPath)
        {
            config.RouteTable.Add("Default", "", "Views/default.dothtml");
            config.RouteTable.Add("DefaultCommercial", "commercial", "Views/Commercial/default.dothtml");
        }

        private void ConfigureControls(DotvvmConfiguration config, string applicationPath)
        {
            // register code-only controls and markup controls
        }

        private void ConfigureResources(DotvvmConfiguration config, string applicationPath)
        {
            // register custom resources and adjust paths to the built-in resources
        }

		public void ConfigureServices(IDotvvmServiceCollection options)
        {
            options.AddDefaultTempStorages("temp");
		}
    }
}
