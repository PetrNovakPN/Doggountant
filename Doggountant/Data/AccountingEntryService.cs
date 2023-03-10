using Microsoft.Maui.Storage;
using System.Linq;
using System.Text.Json;

namespace Doggountant.Data;

public class AccountingEntryService
{
	public string[] Types = new[]
	{
		"J?dlo", "Auto", "Pit?", "RockNroll"
	};

	List<AccountingEntry> Entries = new List<AccountingEntry>() { new AccountingEntry
		{
			Date = DateTime.Now,
			Value = 69.00m,
			Type = "J?dlo",
			Note = "temp",
            EntryType = false
}
	};

	string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\Saves\\entries.txt");

	public List<AccountingEntry> GetEntryAsync()
	{
		string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\Saves\\entries.txt");
		if (!File.Exists(filePath))
		{
			File.Create(filePath);
		}
		if (new FileInfo(filePath).Length != 0)
		{
			Entries.Clear();
			ReadFromFile();
		}
		return Entries;
	}

	public async Task AddEntryAsync(AccountingEntry tempEntry)
	{
		Entries.Add(tempEntry);
		await SaveIntoFile(Entries);
	}

	public async Task RemoveEntryAsync(AccountingEntry tempEntry)
	{
	
		Entries.Remove(Entries.FirstOrDefault(e => e.Date.Date == tempEntry.Date.Date && e.Note == tempEntry.Note && e.Value == tempEntry.Value && e.Type == tempEntry.Type && e.EntryType == tempEntry.EntryType));
		await SaveIntoFile(Entries);
	}

	private void ReadFromFile()
	{
		string json = File.ReadAllText(filePath);
		Entries = JsonSerializer.Deserialize<List<AccountingEntry>>(json);
	}

	private async Task SaveIntoFile(List<AccountingEntry> tempEntries)
	{
		string json = JsonSerializer.Serialize(tempEntries);
		File.WriteAllText(filePath, json);
	}
}


