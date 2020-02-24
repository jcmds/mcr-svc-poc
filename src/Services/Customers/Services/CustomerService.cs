using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Customers
{
    public class CustomerService : GrpcCustomerService.GrpcCustomerServiceBase
    {
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<EmptyResponse> Create(CreateCustomerRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Create a new customer");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<EmptyResponse> Delete(DeleteCustomerRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Delete customer from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<CustomersResponse> GetAll(GetAllCustomersRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get all customers");

            var moq = Enumerable.Range(1, 10)
                .Select(x => new CustomerResponse { LegalName = $"Moq {x}" });

            var response = new CustomersResponse();

            response.Items.AddRange(moq);

            return Task.FromResult(response);
        }

        public override Task<CustomerResponse> GetById(GetByIdCustomerRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get customer from {request.Id}");

            return Task.FromResult(new CustomerResponse { LegalName = "Moq" });
        }

        public override Task<EmptyResponse> Update(UpdateCustomerRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Update a customer from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }
    }
}
