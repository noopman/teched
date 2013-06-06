using System.Web.Mvc;

// ReSharper disable CheckNamespace
namespace GitDemo.Web
// ReSharper restore CheckNamespace
{
	public static class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}