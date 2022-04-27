namespace MauiWidgets;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		MessagingCenter.Subscribe<WidgetActionMessage>(this, string.Empty, async message =>
		{
			await DisplayAlert("ACTION", "Action from Widget started!", "OK");
		});
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);


	}
}

