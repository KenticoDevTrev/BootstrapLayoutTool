using BootstrapLayoutTool;
using Kentico.PageBuilder.Web.Mvc;

[assembly: RegisterSection("Bootstrap4LayoutTool", "Bootstrap 4 Layout", propertiesType: typeof(Bootstrap4LayoutToolProperties), customViewName: "Sections/BootstrapLayoutTool/_Bootstrap4LayoutTool", Description ="Allows you to add a Bootstrap 4 Section with fully configurable layout", IconClass = "icon-l-cols-25-50-25")]