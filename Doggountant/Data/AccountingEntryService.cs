namespace Doggountant.Data;

public class AccountingEntryService
{
	public string[] Types = new[]
	{
		"Jídlo", "Auto", "Pití", "RockNroll"
	};

	public Task<AccountingEntry[]> GetEntryAsync(DateTime startDate)
	{
		return Task.FromResult(Enumerable.Range(1, 50).Select(index => new AccountingEntry
        {
			Date = startDate.AddDays(index),
			Value = Random.Shared.Next(-155, 400),
			Type = Types[Random.Shared.Next(Types.Length)],
			Note = "temp"
		}).ToArray());
	}
}

