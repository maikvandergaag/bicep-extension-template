using Azure.Bicep.Types.Concrete;
using Bicep.Local.Extension.Types.Attributes;
using System.Text.Json.Serialization;

namespace Bicep.Extension.Model {
    [ResourceType("exampleresource")]
    public class ExampleResource : ExampleResourceIdentifiers
    {

        [TypeProperty("The description of the resource")]
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
