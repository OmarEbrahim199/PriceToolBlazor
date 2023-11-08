using Pricetool.Resources;

namespace Pricetool.Components.Navtab.Beregninger
{

    public enum LabelNames
    {
        Label1,
        Label2,
        Label3,
        Label4,
        Label5,
        Label6,
        Label7,
        Label8,
        ValueforLabel8
        // ... other labels
    }
    public static class LabelNamesExtensions
    {
        private static readonly Dictionary<LabelNames, string> LabelMappings = new Dictionary<LabelNames, string>
        {
            { LabelNames.Label1, AppStrings.Label1 },
            { LabelNames.Label2, AppStrings.Label2 },
            { LabelNames.Label3, AppStrings.Label3 },
            { LabelNames.Label4, AppStrings.Label4 },
            { LabelNames.Label5, AppStrings.Label5 },
            { LabelNames.Label6, AppStrings.Label6 },
            { LabelNames.Label7, AppStrings.Label7 },
            { LabelNames.Label8, AppStrings.Label8 },

        };

        public static string GetDisplayValue(this LabelNames label)
        {
            return LabelMappings.TryGetValue(label, out var displayValue) ? displayValue : string.Empty;
        }
    }
}

