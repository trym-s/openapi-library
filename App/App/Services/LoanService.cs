using App.Models;
using System.Text.Json;

namespace App.Services;

public class LoanService : ILoanService
{
    private const string FilePath = "loans.txt";

    public Loan CreateLoan(Loan loan)
    {
        loan.Id = Guid.NewGuid();
        var json = JsonSerializer.Serialize(loan);
        File.AppendAllText(FilePath, json + Environment.NewLine);
        return loan;
    }

    public List<Loan> GetAllLoans()
    {
        if (!File.Exists(FilePath))
            return new List<Loan>();

        var lines = File.ReadAllLines(FilePath);
        return lines
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .Select(l => JsonSerializer.Deserialize<Loan>(l)!)
            .ToList();
    }
}
