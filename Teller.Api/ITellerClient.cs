using Refit;
using System.Text;
using Teller.Api.Contracts;
using Teller.Client.Contracts;

namespace Teller.Api
{
    public interface ITellerClient
    {
        public const string BaseAddress = "https://api.teller.io";

        public Task<List<Account>> GetAccountsAsync(string accessToken) => InternalGetAccountsAsync(BuildAuthorizationHeader(accessToken));

        public Task<Account> GetAccountAsync(string accessToken, string accountId) => InternalGetAccountAsync(BuildAuthorizationHeader(accessToken), accountId);

        public Task<Balance> GetBalanceAsync(string accessToken, string accountId) => InternalGetBalanceAsync(BuildAuthorizationHeader(accessToken), accountId);

        public Task<List<Transaction>> GetTransactionsAsync(string accessToken, string accountId) => 
            InternalGetTransactionsAsync(BuildAuthorizationHeader(accessToken), accountId);

        public Task<List<Transaction>> GetTransactionsAsync(string accessToken, string accountId, int count) =>
            InternalGetTransactionsAsync(BuildAuthorizationHeader(accessToken), accountId, count);

        public Task<List<Transaction>> GetTransactionsAsync(string accessToken, string accountId, int count, string fromId) =>
            InternalGetTransactionsAsync(BuildAuthorizationHeader(accessToken), accountId, count, fromId);

        public async Task<List<string>> GetPaymentsSchemesAsync(string accessToken, string accountId)
        {
            var schemes = await InternalGetPaymentSchemesAsync(BuildAuthorizationHeader(accessToken), accountId);

            return schemes.Schemes.SelectMany(x => x.Values).ToList();
        }

        [Get("/institutions")]
        public Task<List<Institution>> GetInstitutionsAsync();      
        
        [Get("/accounts")]
        protected Task<List<Account>> InternalGetAccountsAsync([Authorize("Basic")] string accessToken);

        [Get("/accounts/{accountId}")]
        protected Task<Account> InternalGetAccountAsync([Authorize("Basic")] string accessToken, string accountId);

        [Get("/accounts/{accountId}/balances")]
        protected Task<Balance> InternalGetBalanceAsync([Authorize("Basic")] string accessToken, string accountId);

        [Get("/accounts/{accountId}/transactions")]
        protected Task<List<Transaction>> InternalGetTransactionsAsync([Authorize("Basic")] string accessToken, string accountId);

        [Get("/accounts/{accountId}/transactions?count={count}")]
        protected Task<List<Transaction>> InternalGetTransactionsAsync([Authorize("Basic")] string accessToken, string accountId, int count);

        [Get("/accounts/{accountId}/transactions?count={count}&from_id={fromId}")]
        protected Task<List<Transaction>> InternalGetTransactionsAsync([Authorize("Basic")] string accessToken, string accountId, int count, string fromId);

        [Options("/accounts/{accountId}/payments")]
        protected Task<PaymentSchemes> InternalGetPaymentSchemesAsync([Authorize("Basic")] string accessToken, string accountId);

        private static string BuildAuthorizationHeader(string accessToken) => Convert.ToBase64String(Encoding.UTF8.GetBytes($"{accessToken}:"));
    }
}
