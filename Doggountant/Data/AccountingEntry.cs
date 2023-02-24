namespace Doggountant.Data;

public class AccountingEntry
{

	public int Value { get; set; }

	public string Type {get; set; }

	public DateTime Date { get; set; }

	public string Note { get; set; }

    public bool EntryType { get; set; } //false = v�dej, true = p��jem

    public AccountingEntry()
	{
		Value = 0;
		Type = "J�dlo";
		Date = DateTime.MinValue;
		Note = "temp";
        EntryType = false;
	}
}