using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class BankAccountService : GrpcBankAccountService.GrpcBankAccountServiceBase
    {
        private readonly ILogger<BankAccountService> _logger;

        public BankAccountService(ILogger<BankAccountService> logger)
        {
            _logger = logger;
        }

        public override Task<EmptyResponse> Create(CreateBankAccountRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Create a new bank account");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<EmptyResponse> Delete(DeleteBankAccountRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Delete bank account from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }

        public override Task<BankAccountsResponse> GetAll(GetAllBankAccountsRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get all banks accounts");

            var moq = Enumerable.Range(1, 10)
                .Select(x => new BankAccountResponse { Description = $"Moq {x}", AccountNumberDig = x, AgDig = x });

            var response = new BankAccountsResponse();

            response.Items.AddRange(moq);

            return Task.FromResult(response);
        }

        public override Task<BankAccountResponse> GetById(GetByIdBankAccountRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Get bank account from {request.Id}");

            return Task.FromResult(new BankAccountResponse { Description = "Moq" });
        }

        public override Task<EmptyResponse> Update(UpdateBankAccountRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Update a bank account from id: {request.Id}");

            return Task.FromResult(new EmptyResponse());
        }
    }
}
