namespace Doggountant.Data;

public class AccountingEntry
{

	public int Value { get; set; }

	public string Type {get; set; }

	public DateTime Date { get; set; }

	public string Note { get; set; }

	public AccountingEntry()
	{
		Value = 0;
		Type = "Jídlo";
		Date = DateTime.MinValue;
		Note = "temp";
	}

}
