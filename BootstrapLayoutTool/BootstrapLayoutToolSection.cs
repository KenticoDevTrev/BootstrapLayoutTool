using BootstrapLayoutTool;
using Kentico.PageBuilder.Web.Mvc;

[assembly: RegisterSection("Bootstrap3LayoutTool", "Bootstrap 3 Layout", propertiesType: typeof(Bootstrap3LayoutToolProperties), customViewName: "Sections/BootstrapLayoutTool/_Bootstrap3LayoutTool", Description ="Allows you to add a Bootstrap 3 Section with fully configurable layout", IconClass = "icon-l-cols-25-50-25")]