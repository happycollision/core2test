using JsonApiDotNetCore.Models;

namespace core2test.Models
{
    public class Person : Identifiable
    {
        [Attr("name")]
        public string Name { get; set; }

        [Attr("isHappy")]
        public bool IsHappy { get; set; }
    }
}