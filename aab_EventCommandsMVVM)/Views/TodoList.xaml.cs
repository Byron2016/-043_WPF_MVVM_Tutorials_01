using aab_EventCommandsMVVM_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aab_EventCommandsMVVM_.Views
{
    /// <summary>
    /// Interaction logic for TodoList.xaml
    /// </summary>
    public partial class TodoList : UserControl
    {
        //Using DependencyProperty
        public ICommand LoadCommand
        {
            get { return (ICommand)GetValue(LoadCommandProperty); }
            set { SetValue(LoadCommandProperty, value); }
        }

        public static readonly DependencyProperty LoadCommandProperty = DependencyProperty.Register("LoadCommand", typeof(ICommand), typeof(TodoList), new PropertyMetadata(null));

        //Add DependencyProperty
        public ICommand SelectedTodoItemsChangedCommand
        {
            get { return (ICommand)GetValue(SelectedTodoItemsChangedCommandProperty); }
            set { SetValue(SelectedTodoItemsChangedCommandProperty, value); }
        }

        public static readonly DependencyProperty SelectedTodoItemsChangedCommandProperty =
            DependencyProperty.Register("SelectedTodoItemsChangedCommand", typeof(ICommand), typeof(TodoList), new PropertyMetadata(null));



        public TodoList()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // (DataContext as TodoListViewModel).LoadTodoItemsCommand.Execute(null); //SOLUCION 1

            if (LoadCommand != null)
            {
                LoadCommand.Execute(null);
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedTodoItemsChangedCommand != null)
            {
                SelectedTodoItemsChangedCommand.Execute(lvTodoItems.SelectedItems);
            }
        }
    }
}
