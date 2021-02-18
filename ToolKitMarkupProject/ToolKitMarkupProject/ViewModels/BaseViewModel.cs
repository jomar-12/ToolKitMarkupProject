using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ToolKitMarkupProject.ViewModels
{
    public class BaseViewModel : ObservableProperty
    {
        public Dictionary<string, ICommand> Commands { get; protected set; }

        public BaseViewModel()
        {
            Commands = new Dictionary<string, ICommand>();
        }
    }
}
