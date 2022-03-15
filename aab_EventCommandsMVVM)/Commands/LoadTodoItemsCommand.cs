using aab_EventCommandsMVVM_.Models;
using aab_EventCommandsMVVM_.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aab_EventCommandsMVVM_.Commands
{
    public class LoadTodoItemsCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly TodoListViewModel _todoListViewModel;

        public LoadTodoItemsCommand(TodoListViewModel todoListViewModel)
        {
            _todoListViewModel = todoListViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            // Get todo list items from API.
            IEnumerable<TodoItem> todoItems = await GetTodoItemsAsync();

            // Set the todo list items on the view model.
            _todoListViewModel.TodoItems = new ObservableCollection<TodoItem>(todoItems);
        }

        private async Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
        {
            return await Task.FromResult(new[]
            {
                new TodoItem()
                {
                    Description = "Walk the dog.",
                    IsCompleted = false,
                    OwnerName = "John"
                },
                new TodoItem()
                {
                    Description = "Take out the trash.",
                    IsCompleted = false,
                    OwnerName = "Mary"
                },
                new TodoItem()
                {
                    Description = "Upload YouTube video.",
                    IsCompleted = true,
                    OwnerName = "SingletonSean"
                }
            });
        }
    }
}
