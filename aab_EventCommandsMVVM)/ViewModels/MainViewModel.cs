using aab_EventCommandsMVVM_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aab_EventCommandsMVVM_.ViewModels
{
    public class MainViewModel : ObservableObject
    {
		private TodoListViewModel _todoListViewModel;
		public TodoListViewModel TodoListViewModel
		{
			get
			{
				return _todoListViewModel;
			}
			set
			{
				_todoListViewModel = value;
				OnPropertyChanged(nameof(TodoListViewModel));
			}
		}

		public MainViewModel()
		{
			TodoListViewModel = new TodoListViewModel();
		}
	}
}
