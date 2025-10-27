using Bicep.Extension.Model;
using Bicep.Local.Extension.Host.Handlers;
using System.Reflection;

namespace Bicep.Extension.Handler {
    public class ExampleHandler : TypedResourceHandler<ExampleResource, ExampleResourceIdentifiers> {
        protected override async Task<ResourceResponse> Preview(ResourceRequest request, CancellationToken cancellationToken) {
            await Task.CompletedTask;
            return GetResponse(request);
        }

        protected override async Task<ResourceResponse> CreateOrUpdate(ResourceRequest request, CancellationToken cancellationToken) {
            await Task.CompletedTask;
            return GetResponse(request);
        }

        protected override ExampleResourceIdentifiers GetIdentifiers(ExampleResource properties)
            => new() {
                Name = properties.Name,
            };
    }
}