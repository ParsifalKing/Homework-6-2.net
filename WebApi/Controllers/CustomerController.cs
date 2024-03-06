using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Infrastructure.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly CustomerService _customerService;

    public CustomerController()
    {
        _customerService = new CustomerService();
    }

    [HttpPost("add-customer")]
    public void AddCustomer(Customer customer)
    {
        _customerService.AddCustomer(customer);
    }

    [HttpGet("get-customers")]
    public List<Customer> GetCustomers()
    {
        return _customerService.GetCustomers();
    }

    [HttpPut("update-customer")]
    public void UpdateCustomer(Customer customer)
    {
        _customerService.UpdateCustomer(customer);
    }

    [HttpDelete("delete-customer")]
    public void DeleteCustomer(int id)
    {
        _customerService.DeleteCustomer(id);
    }

    [HttpGet("get-customers-transactions")]
    public List<CustomerTransactions> GetCustomersTransactions()
    {
        return _customerService.GetCustomersTransactions();
    }




}
