using JsonApiDotNetCore.Models;

namespace core2test.Models
{
    public class Person : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }
        public bool IsHappy { get; set; }
    }
}