namespace Doggountant.Data;

public class AccountingEntry
{

	public decimal Value { get; set; }

	public string Type {get; set; }

	public DateTime Date { get; set; }

	public string Note { get; set; }

    public bool EntryType { get; set; } //false = výdej, true = pøíjem

    public AccountingEntry()
	{
		Value = 0.00m;
		Type = "Jídlo";
		Date = DateTime.MinValue;
		Note = "temp";
        EntryType = false;
	}
}