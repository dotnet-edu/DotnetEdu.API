using System.Text.Json;

namespace DotnetEdu.Service.Helpers;

public class EnumToStringConverter : StringEnumConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToString());
    }
}