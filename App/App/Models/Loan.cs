namespace App.Models;

public enum LoanStatus
{
    Ongoing,
    Returned,
    Late
}

public class Loan
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid BookId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public LoanStatus Status { get; set; }
}
