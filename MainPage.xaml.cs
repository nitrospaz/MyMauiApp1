﻿namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;
	public const double DefaultFontSize = 24;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


public class GlobalFontSizeExtension : IMarkupExtension<double>
{
	public double ProvideValue(IServiceProvider serviceProvider)
	{
		return MainPage.DefaultFontSize;
	}

	object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
	{
		return (this as IMarkupExtension<double>).ProvideValue(serviceProvider);
	}
}

