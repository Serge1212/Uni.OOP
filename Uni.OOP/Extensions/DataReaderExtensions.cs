using System.Data;
using System.Reflection;

namespace Uni.OOP.Extensions
{
    /// <summary>
    /// The extensions for <see cref="IDataReader"/>
    /// </summary>
    public static class DataReaderExtensions
    {
        public static IList<TResult> MapToCollection<TResult>(this IDataReader reader) where TResult : new()
        {
            var resultList = new List<TResult>();
            while (reader.Read())
            {
                var item = new TResult();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var property = typeof(TResult).GetProperty(reader.GetName(i), BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    if (property != null && !reader.IsDBNull(i))
                    {
                        property.SetValue(item, reader.GetValue(i));
                    }
                }
                resultList.Add(item);
            }
            return resultList;
        }
    }
}
