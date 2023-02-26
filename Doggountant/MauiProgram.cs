using Microsoft.AspNetCore.Components.WebView.Maui;
using Doggountant.Data;
using MudBlazor.Services;

namespace Doggountant;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<AccountingEntryService>();
		builder.Services.AddSingleton<AccountingEntryTypeService>();
        builder.Services.AddSingleton<MoneyStatsModel>();

        return builder.Build();
	}
}
