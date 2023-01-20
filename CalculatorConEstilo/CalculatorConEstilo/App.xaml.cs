namespace CalculatorConEstilo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MVVM.View.CalculatorView(); 
	}
}

