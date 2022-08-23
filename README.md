
# BootstrapLayoutTool
Bootstrap Layout Tool for Kentico MVC, allows you to add Sections with various columns and css classes for Bootstrap 4 sites.

# Installation (Bootstrap 5, .net Core support only)
1. Install the `XperienceCommunity.Bootstrap5LayoutTool`  to your MVC Site

This is also available in a Page Builder Containered version at `XperienceCommunity.Bootstrap5Layout.PageBuilderContainered`

# Installation (Bootstrap 4, .net Core or .net 4.8)
1. Install the `BootstrapLayoutTool.Kentico.MVC` for .net 4.8 Framework or `BootstrapLayoutTool.Kentico.MVC.Core` for .net Core NuGet Package to your MVC Site

This is also available in a Page Builder Containered version at `BootstrapLayoutTool.PageBuilderContainered.Kentico.MVC` or `BootstrapLayoutTool.PageBuilderContainered.Kentico.MVC.Core`

<<<<<<< HEAD

# Usage
1. On a Page where Page Builder is Enabled, add a new Section or configure the current section and select the Bootstrap 4 Layout / Bootstrap 5 Layout
=======
# Usage Page Builder
1. On a Page where Page Builder is Enabled, add a new Section or configure the current section and select the Bootstrap 4 Layout
>>>>>>> 0064653f5391d727307b4e52ecc79eb80feba0d5
1. Click on the Section Properties Configuration Icon (Cogwheel) and Configure as desired.

# Usage Form Builder
1. On the Form Builder in the Admin UI, add a new Section and select the Bootstrap 4 Layout
1. Click on the Section Properties Configuration Icon (Cogwheel) and Configure as desired

*Note: You can hover over the various field's input's to get tooltips such as Bootstrap 4 class name conventions*

# Form Sections
For .Net Core KX 13 Refresh 2 (hotfix 31), this tool now has a dynamic Bootstrap Layout Form Section.  This will allow you to more easily implement .net core.  I only created this on the .net Core version for now, if you need this for Xperience 13 .net 4.8, please message me and i'll convert it (pain to do, so hoping to avoid).

## Upgrading from 13.0.X
If you used the Bootstrap Layout Tool's form sections that were in the previous version, you will need to install the [BootstrapLayoutTool.Kentico.MVC.Core.Transition](https://www.nuget.org/packages/BootstrapLayoutTool.Kentico.MVC.Core.Transition/) package which contains the 'old' non dynamic form layouts. I would then switch these old ones to use the new Bootstrap 4 Layout form section, then uninstall the transition nuget package.  This is only because Xperience throws an error if you try to edit a form and the form sections are missing.

# Form Widget Overrides
Included in the repo is a [class you can include on your MVC solution](https://github.com/KenticoDevTrev/BootstrapLayoutTool/blob/master/Bootstrap-FormWidget-Customization.cs) to fix up the form widget rendering to be more bootstrap orientated.  You can copy and paste and the modify this as you need.  It includes some samples of how to do normal, inline, and horizontal forms.

# Contributions, but fixes and License
Feel free to Fork and submit pull requests to contribute.

You can submit bugs through the issue list and i will get to them as soon as i can, unless you want to fix it yourself and submit a pull request!

This is free to use and modify!

# Compatability
Can be used on any Kentico 12 SP site (hotfix 29 or above) and Kentico Xperience 13 (.Net Framework and .Net Core), and for the Form Builder version Kentico Xperience 13 refresh 2 (hotfix 31) for .Net Core
