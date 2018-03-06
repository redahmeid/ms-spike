using System.Text.RegularExpressions;
using Newtonsoft.Json.Serialization;

namespace ThamesWater.Helpers
{
    public class SnakeCaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return GetSnakeCase(propertyName);
        }

        private string GetSnakeCase(string input)
        {
            return Regex.Replace(input, "(?<=[a-z0-9])[A-Z]", m => "_" + m.Value).ToLowerInvariant();
        }
    }
}
