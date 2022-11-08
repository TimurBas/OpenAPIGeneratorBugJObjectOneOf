using Newtonsoft.Json;
using Org.OpenAPITools.Model;

namespace OpenAPIGeneratorBugJObjectOneOf.xUnit
{
    public class OneOfTest
    {
        [Fact]
        public void Test()
        {
            var json = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\test.json");
            var model = JsonConvert.DeserializeObject<List<OneOfSchema>>(json);
            var debug = "";
        }
    }
}