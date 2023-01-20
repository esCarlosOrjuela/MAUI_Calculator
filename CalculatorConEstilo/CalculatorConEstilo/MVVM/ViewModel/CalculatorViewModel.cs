using System;
using System.Windows.Input;
using Dangl.Calculator;
using PropertyChanged;

namespace CalculatorConEstilo.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {

        public string Formula { get; set; }
        public string Result { get; set; } = "0";

        public ICommand OperationCommand => new Command((number) => Formula += number);
        public ICommand ResetCommand => new Command((number) =>
                                            {
                                                Result = "0";
                                                Formula = string.Empty;
                                            });
        public ICommand BackspaceCommand => new Command((number) =>
        {
            if (Formula.Length > 0)
            {
                Formula = Formula.Substring(0, Formula.Length - 1);
            }
        });

        public ICommand CalculeteCommand => new Command((number) =>
        {
            if (Formula.Length == 0)
                return;

            var calculate = Calculator.Calculate(Formula);
            Result = calculate.Result.ToString();
        });

        public CalculatorViewModel()
        {
        }
    }
}

