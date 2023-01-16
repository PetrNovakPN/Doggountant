﻿using Microsoft.Maui.Storage;
using System.Linq;
using System.Text.Json;

namespace Doggountant.Data
{
	internal class AccountingEntryTypeService
	{
		List<AccountingEntryType> Types = new List<AccountingEntryType>() { new AccountingEntryType
			{
				Type = "Jídlo",
			} 
		};
		string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\Saves\\types.txt");

		public List<AccountingEntryType> GetTypesAsync()
		{
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\Saves\\types.txt");
			if (!File.Exists(filePath))
			{
				File.Create(filePath);
			}
			if (new FileInfo(filePath).Length != 0)
			{
				Types.Clear();
				ReadFromFile();
			}
			return Types;
		}
		
		public async Task SaveTypesAsync(AccountingEntryType tempType)
		{
			Types.Add(tempType);
			SaveIntoFile(Types);
		}
		private void  ReadFromFile()
		{
			string json = File.ReadAllText(filePath);
			Types = JsonSerializer.Deserialize<List<AccountingEntryType>>(json);
		}

		private void SaveIntoFile(List<AccountingEntryType> TempTypes)
			{
				string json = JsonSerializer.Serialize(TempTypes);
				File.WriteAllText(filePath, json);
			}
		}
}