using Infrastructure.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    private readonly TransactionService _transactionService;

    public TransactionController()
    {
        _transactionService = new TransactionService();
    }


    [HttpPost("transaction")]
    public string Transaction(Transaction transaction)
    {
        return _transactionService.Transaction(transaction);
    }

    [HttpGet("get-transactions-by-date")]
    public List<Transaction> GetTransactionsByDate(DateTime transactionDate)
    {
        return _transactionService.GetTransactionsByDate(transactionDate);
    }

    [HttpGet("get-transactions-by-sum")]
    public List<Transaction> GetTransactionsBySum(Double sum)
    {
        return _transactionService.GetTransactionsBySum(sum);
    }


}
