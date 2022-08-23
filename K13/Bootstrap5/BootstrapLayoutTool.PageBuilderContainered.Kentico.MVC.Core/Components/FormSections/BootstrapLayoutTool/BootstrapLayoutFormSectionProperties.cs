using BootstrapLayoutTool;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using PageBuilderContainers;

[assembly: RegisterFormSection(Bootstrap5LayoutToolFormSectionProperties.IDENTITY, "Bootstrap 5 Layout", Bootstrap5LayoutToolFormSectionProperties.VIEWPATH, PropertiesType = typeof(Bootstrap5LayoutToolFormSectionProperties), Description = "Allows you to add a Bootstrap 5 Section with fully configurable layout", IconClass = "icon-l-cols-25-50-25")]
namespace BootstrapLayoutTool
{
    public class Bootstrap5LayoutToolFormSectionProperties : PageBuilderWithHtmlBeforeAfterSectionProperties,  IFormSectionProperties
    {
        public const string IDENTITY = "Bootstrap5LayoutToolFormSection";
        public const string VIEWPATH = "~/Views/Components/FormSections/BootstrapLayoutTool/_Bootstrap5LayoutToolFormSection.cshtml";

        const string AdditionalCSSToolTip = @"Additional Classes to append to the Column.  

Bootstrap 5 Examples:
form-check: for checkboxes (input should have class form-check-input and label should have class form-check-label)
form-check-inline: renders the form-check-input and form-check-label inline (input should have class form-check-input and label should have class form-check-label)

Additional Sizes: col-[Size]-[Column Count]
Visible on Size:  d-[Size]-[block|flex|inline|inline-block|inline-flex]
Hide on Size: d-[Size]-none
Offset: offset-[Size]-[Column Count]
Ordering: order-[Size]-[Order Number 0 start, max 5]
Padding: [p|pt|pr|pb|pl|px|py]-[Size]-[Number]
Margin: [m|mt|mr|mb|ml|mx|my]-[Size]-[Number]
Text: text-[Size]-[start|end|center], text-justify

Definitions: 
Sizes: (empty for default/xs), sm-, md-, lg-, xl- xxl-
Column Count: 1-12

NOTE: For default size, don't include the - between.  Ex: col-12 is default, col-sm-12 is small";

        const string ColumnWidthOptions = @";Do not render column div
0;Flex
-1;1 Column (8%)
-2;2 Column (16%)
-3;3 Column (25%)
-4;4 Column (33%)
-5;5 Column (42%)
-6;6 Column (50%)
-7;7 Column (58%)
-8;8 Column (66%)
-9;9 Column (75%)
-10;10 Column (83%)
-11;11 Column (92%)
-12;12 Column (100%)";

        const string PrependDataSource = @"col;Extra Small (0px to 575px)
col-sm;Small (576px to 767px)
col-md;Medium (768px to 991px)
col-lg;Large (992px to 1199px)
col-xl;Extra Large (1200px to 1399px)
col-xxl;Extra extra large (1400px)";

        const string ColumnWidthTooltip = @"The number of columns-spaces this column takes up.";
        const string FormModeTooltip = @"How you want this section's form-group to apply.  
On Column = form-group is applied to the columns
On Row = form-group is applied to the row itself;
None = form-group is not set anywhere, you must set it manually";

        const string FormModeOptions = @"column;On Column
row;On row
none;None";
        const string DefaultFormMode = "column";

        const string DefaultColumnWidth = "-12";

        public Bootstrap5LayoutToolFormSectionProperties()
        {
        }

        // Column 1
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 0, Label = "form-group Automation", Tooltip = FormModeTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), FormModeOptions)]
        public string FormModeConfiguration { get; set; } = DefaultFormMode;


        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 1, Label = "Columns", Tooltip = "Sets the number of columns in the layout.  Maximum of 12")]
        public int Columns { get; set; } = 1;

        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 2, Label = "Column CSS Prepend", Tooltip = "This will define what the default column sizing will be.  For example, if you select \"Small\" then your column widths will be col-sm-#")]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), PrependDataSource)]
        public string ColumnCSSPrepend { get; set; } = "col-md";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Container CSS", Tooltip = @"Additional CSS that will wrap the columns, this can be used to for styling purposes.

form-inline: make an inline form
form-row: makes the column spacing tighter
Remove Gutters: no-gutters;")]
        public string ContainerCSS { get; set; }

        public string ContainerFormGroupCSS { get
            {
                return FormModeConfiguration?.Equals("row") ?? false ? "form-group" : "";
            } 
        }

        // Column 1
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 4, Label = "1st Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column1Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "1st Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column1AdditionalCSS { get; set; }

        // Column 2
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 6, Label = "2nd Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column2Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7, Label = "2nd Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column2AdditionalCSS { get; set; }

        // Column 3
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 8, Label = "3rd Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column3Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 9, Label = "3rd Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column3AdditionalCSS { get; set; }

        // Column 4
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 10, Label = "4th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column4Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 11, Label = "4th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column4AdditionalCSS { get; set; }

        // Column 5
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 12, Label = "5th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column5Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 13, Label = "5th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column5AdditionalCSS { get; set; }

        // Column 6
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 14, Label = "6th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column6Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 15, Label = "6th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column6AdditionalCSS { get; set; }

        // Column 7
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 16, Label = "7th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column7Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 17, Label = "7th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column7AdditionalCSS { get; set; }

        // Column 8
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 18, Label = "8th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column8Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 19, Label = "8th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column8AdditionalCSS { get; set; }

        // Column 9
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 20, Label = "9th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column9Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 21, Label = "9th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column9AdditionalCSS { get; set; }

        // Column 10
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 22, Label = "10th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column10Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 23, Label = "10th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column10AdditionalCSS { get; set; }

        // Column 11
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 24, Label = "11th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column11Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 25, Label = "11th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column11AdditionalCSS { get; set; }

        // Column 12
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 26, Label = "12th Column Size", Tooltip = ColumnWidthTooltip)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ColumnWidthOptions)]
        public string Column12Width { get; set; } = DefaultColumnWidth;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 27, Label = "12th Column Additional CSS", Tooltip = AdditionalCSSToolTip)]
        public string Column12AdditionalCSS { get; set; }

        /// <summary>
        /// Helper to get the Column Width
        /// </summary>
        /// <param name="ColumnNum">The column number</param>
        /// <returns>The column width post-pend value</returns>
        public string GetColumnBootstrapClass(int ColumnNum)
        {
            string Value = "";

            switch (ColumnNum)
            {
                default:
                case 1:
                    Value = Column1Width;
                    break;
                case 2:
                    Value = Column2Width;
                    break;
                case 3:
                    Value = Column3Width;
                    break;
                case 4:
                    Value = Column4Width;
                    break;
                case 5:
                    Value = Column5Width;
                    break;
                case 6:
                    Value = Column6Width;
                    break;
                case 7:
                    Value = Column7Width;
                    break;
                case 8:
                    Value = Column8Width;
                    break;
                case 9:
                    Value = Column9Width;
                    break;
                case 10:
                    Value = Column10Width;
                    break;
                case 11:
                    Value = Column11Width;
                    break;
                case 12:
                    Value = Column12Width;
                    break;
            }

            // Handle the 0 or if no item is set to default properly
            switch (Value)
            {
                case "0":
                    return ColumnCSSPrepend;
                case "":
                    return "";
                default:
                    return ColumnCSSPrepend + Value;
            }
        }

        /// <summary>
        /// Helper to get the Additional CSS for the given column
        /// </summary>
        /// <param name="ColumnNum">The column number</param>
        /// <returns>Any additional CSS classes</returns>
        public string GetColumnAdditionalCSS(int ColumnNum)
        {
            string FormGroup = (FormModeConfiguration.Equals("column") ? " form-group" : "");
            switch (ColumnNum)
            {
                default:
                case 1:
                    return Column1AdditionalCSS+ FormGroup;
                case 2:
                    return Column2AdditionalCSS + FormGroup;
                case 3:
                    return Column3AdditionalCSS + FormGroup;
                case 4:
                    return Column4AdditionalCSS + FormGroup;
                case 5:
                    return Column5AdditionalCSS + FormGroup;
                case 6:
                    return Column6AdditionalCSS + FormGroup;
                case 7:
                    return Column7AdditionalCSS + FormGroup;
                case 8:
                    return Column8AdditionalCSS + FormGroup;
                case 9:
                    return Column9AdditionalCSS + FormGroup;
                case 10:
                    return Column10AdditionalCSS + FormGroup;
                case 11:
                    return Column11AdditionalCSS + FormGroup;
                case 12:
                    return Column12AdditionalCSS + FormGroup;
            }
        }

        public bool ShowColumnsDiv(int ColumnNum)
        {
            return (GetColumnAdditionalCSS(ColumnNum) + GetColumnBootstrapClass(ColumnNum)).Trim().Length > 0;
        }
    }
}
