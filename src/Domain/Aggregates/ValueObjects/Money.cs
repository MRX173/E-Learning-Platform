using Domain.Common;

namespace Domain.ValueObjects;

public class Money : ValueObject
{
   public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        if (amount < 0)
            throw new Exception("Amount cannot be negative");

        if (string.IsNullOrWhiteSpace(currency))
            throw new Exception("Currency is required");

        Amount = amount;
        Currency = currency;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}
