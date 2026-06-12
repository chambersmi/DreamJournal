using System.ComponentModel;
using System.Reflection;

namespace DreamJournal.Domain.Extensions
{
    /// <summary>
    /// This static class converts Enums into their descriptions.
    /// Example: MI -> Michigan
    /// Example: US -> United States
    /// </summary>
    public static class EnumExtension
    {
        public static string ToDescriptionString(this Enum val)
        {
            var field = val.GetType().GetField(val.ToString());
            if (field == null) return val.ToString();

            DescriptionAttribute[] attributesArray = (DescriptionAttribute[])field
                .GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributesArray.Length > 0 ? attributesArray[0].Description : val.ToString();
        }
    }
}
