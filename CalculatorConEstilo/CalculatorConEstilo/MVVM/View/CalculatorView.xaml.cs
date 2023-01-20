using CalculatorConEstilo.MVVM.ViewModel;

namespace CalculatorConEstilo.MVVM.View;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();

    }
}
