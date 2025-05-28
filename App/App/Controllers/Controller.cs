using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Services;

namespace App.Controllers;

[ApiController]
[Route("loans")]
public class Controller : ControllerBase
{
    private readonly ILoanService _loanService;

    public Controller(ILoanService loanService)
    {
        _loanService = loanService;
    }

    [HttpPost]
    public IActionResult CreateLoan([FromBody] Loan loan)
    {
        var created = _loanService.CreateLoan(loan);
        return Created("", created);
    }

    [HttpGet]
    public IActionResult GetAllLoans()
    {
        var loans = _loanService.GetAllLoans();
        return Ok(loans);
    }
}
