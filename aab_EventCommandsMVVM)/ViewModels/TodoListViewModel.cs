﻿using aab_EventCommandsMVVM_.Commands;
using aab_EventCommandsMVVM_.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aab_EventCommandsMVVM_.ViewModels
{
    public class TodoListViewModel : ObservableObject
    {
		private ObservableCollection<TodoItem> _todoItems;
		public ObservableCollection<TodoItem> TodoItems
		{
			get
			{
				return _todoItems;
			}
			set
			{
				_todoItems = value;
				OnPropertyChanged(nameof(TodoItems));
			}
		}

		public ICommand LoadTodoItemsCommand { get; set; }

		public TodoListViewModel()
		{
			LoadTodoItemsCommand = new LoadTodoItemsCommand(this);


			//LoadTodoItemsCommand.Execute(null);
		}
	}
}
