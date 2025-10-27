using Azure.Bicep.Types.Concrete;
using Bicep.Local.Extension.Types.Attributes;

namespace Bicep.Extension.Model {
    public class ExampleResourceIdentifiers {
        [TypeProperty("The Http Call Name", ObjectTypePropertyFlags.Identifier | ObjectTypePropertyFlags.Required)]
        public required string Name { get; set; }
    }
}
