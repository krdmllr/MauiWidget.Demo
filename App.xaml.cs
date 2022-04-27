namespace MauiWidgets;

public partial class App : Application
{
	public App(IServiceProvider mauiContext)
	{
		InitializeComponent();

		MainPage = new MainPage();
        Services = mauiContext;
    }

    public IServiceProvider Services { get; }
}
