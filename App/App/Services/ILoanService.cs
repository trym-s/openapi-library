using App.Models;

namespace App.Services;

public interface ILoanService
{
    Loan CreateLoan(Loan loan);
    List<Loan> GetAllLoans();
}
