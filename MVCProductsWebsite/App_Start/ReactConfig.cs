using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MVCProductsWebsite.ReactConfig), "Configure")]

namespace MVCProductsWebsite
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            ReactSiteConfiguration.Configuration
                .AddScript("~/Scripts/App.js");
		}
	}
}