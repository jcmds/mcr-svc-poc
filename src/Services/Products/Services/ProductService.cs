using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace Products
{
    public class ProductService : GrpcProductService.GrpcProductServiceBase
    {
        private readonly ILogger<ProductService> _logger;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public override Task<EmptyResponse> Create(CreateProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Create a new bank account");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<EmptyResponse> Delete(DeleteProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Delete bank account from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<ProductsResponse> GetAll(GetAllProductsRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get all banks Products");

            var moq = Enumerable.Range(1, 10)
                .Select(x => new ProductResponse { Description = $"Moq {x}" });

            var response = new ProductsResponse();

            response.Items.AddRange(moq);

            return Task.FromResult(response);
        }

        public override Task<ProductResponse> GetById(GetByIdProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get bank account from {request.Id}");

            return Task.FromResult(new ProductResponse { Description = "Moq" });
        }

        public override Task<EmptyResponse> Update(UpdateProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Update a bank account from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }
    }
}
