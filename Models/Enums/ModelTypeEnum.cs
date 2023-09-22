using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace M3P_BackEnd_Squad1.Models.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModelType
    {
        Bermuda,
        Biquíni,
        Bolsa,
        Boné,
        Calça,
        Calçados,
        Camisa,
        Chapéu,
        Saia
    }
}