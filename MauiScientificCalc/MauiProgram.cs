﻿namespace MauiScientificCalc;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Cairo-light.ttf", "RegularFont");
				fonts.AddFont("Cairo-ExtraLight.ttf", "LightFont");
			});

		return builder.Build();
	}
}
