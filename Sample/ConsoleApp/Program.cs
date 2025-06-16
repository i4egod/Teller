using Refit;
using System.Security.Cryptography.X509Certificates;
using Teller.Api;

var accessToken = ""; // Replace with your actual access token

var handler = new HttpClientHandler();
handler.ClientCertificates.Add(new X509Certificate2("certificate.pfx"));

var apiClient = RestService.For<ITellerClient>(ITellerClient.BaseAddress, new RefitSettings { HttpMessageHandlerFactory = () => handler });

var accounts = await apiClient.GetAccountsAsync(accessToken);
Console.WriteLine($"Total Accounts loaded: {accounts.Count}");

var account = await apiClient.GetAccountAsync(accessToken, accounts[0].Id);
Console.WriteLine($"First Account Id: {account.Id}");
Console.WriteLine($"First Account Institution: {account.Institution.Name}");

var balance = await apiClient.GetBalanceAsync(accessToken, accounts[0].Id);
Console.WriteLine($"First Account Balance: {balance.Available} {account.Currency}");

var transactions = await apiClient.GetTransactionsAsync(accessToken, accounts[0].Id, 5);

Console.WriteLine($"First 5 Transactions for Account {account.Id}:");
foreach (var transaction in transactions)
{
    Console.WriteLine($" - {transaction.Description} ({transaction.Type}): {transaction.Amount} {account.Currency}");
}

var institutions = await apiClient.GetInstitutionsAsync();
Console.WriteLine($"Total Institutions loaded: {institutions.Count}");

Console.WriteLine("Press ENTER to exit...");
Console.ReadLine();

