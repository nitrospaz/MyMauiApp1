namespace MauiApp1;

public class TestPage : ContentPage
{
	//Example: can code a page completely in C# without using XAML
	int count = 0;

	Label lblCounter = new Label
	{
		Text = "0",
		FontSize = 50,
		HorizontalOptions = LayoutOptions.Center,
		VerticalOptions = LayoutOptions.Center
	};

	public TestPage()
	{
		var scrollView = new ScrollView();

		var stackLayout = new StackLayout();
		scrollView.Content = stackLayout;

		lblCounter = new Label
		{
			Text = "Count : 0",
			FontSize = 22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center,
		};
		stackLayout.Children.Add(lblCounter);

		var btnIncrement = new Button
		{
			Text = "Increment",
			FontSize = 22,
			HorizontalOptions = LayoutOptions.Center,
		};
		stackLayout.Children.Add(btnIncrement);

		var btnDecrement = new Button
		{
			Text = "Decrement",
			FontSize = 22,
			HorizontalOptions = LayoutOptions.Center,
		};
		stackLayout.Children.Add(btnDecrement);

		btnIncrement.Clicked += BtnIncrement_Clicked;
		btnDecrement.Clicked += BtnDecrement_Clicked;

		this.Content = stackLayout;
	}

	private void BtnIncrement_Clicked(object sender, EventArgs e)
	{
		// increment count
		count++;
		//update label
		lblCounter.Text = $"Click Count : {count}";
		// ada
		SemanticScreenReader.Announce($"Click Count : {count}");
	}

	private void BtnDecrement_Clicked(object sender, EventArgs e)
	{
		// decrement count
		count--;
		//update label
		lblCounter.Text = $"Click Count : {count}";
		// ada
		SemanticScreenReader.Announce($"Click Count : {count}");
	}
}