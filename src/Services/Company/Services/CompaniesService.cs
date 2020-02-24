using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace Company
{
    public class CompaniesService : GrpcCompanyService.GrpcCompanyServiceBase
    {
        private readonly ILogger<CompaniesService> _logger;

        public CompaniesService(ILogger<CompaniesService> logger)
        {
            _logger = logger;
        }

        public override Task<EmptyResponse> Create(CreateCompanyRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Create a new company");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<EmptyResponse> Delete(DeleteCompanyRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Delete company from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<CompaniesResponse> GetAll(GetAllCompaniesRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get all companies");

            var moq = Enumerable.Range(1, 10)
                .Select(x => new CompanyResponse { LegalName = $"Moq {x}" });

            var response = new CompaniesResponse();

            response.Items.AddRange(moq);

            return Task.FromResult(response);
        }

        public override Task<CompanyResponse> GetById(GetByIdCompanyRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get company from {request.Id}");

            return Task.FromResult(new CompanyResponse { LegalName = "Moq" });
        }

        public override Task<EmptyResponse> Update(UpdateCompanyRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Update a company from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }
    }
}
