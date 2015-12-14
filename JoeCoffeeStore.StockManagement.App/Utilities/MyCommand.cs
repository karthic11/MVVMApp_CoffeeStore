using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JoeCoffeeStore.StockManagement.App.Utilities
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        private Action<object> execute;
        private Predicate<object> canExecute;

        public MyCommand(Action<object> Execute, Predicate<object> Canexecute)
        {
            this.execute = Execute;
            this.canExecute = Canexecute;
        }

        public bool CanExecute(object parameter)
        {
            bool result = (canExecute == null) ? true : canExecute(parameter);
            return result;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
