using System.ComponentModel;

namespace MovieDB.Models.Enums
{
    public enum ShowType
    {
        [Description("TV Show")] TVSHOW,
        [Description("Movie")] MOVIE
    }

    public static class ShowTypeExtensions
    {
        public static string ToDescriptionString(this ShowType val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
