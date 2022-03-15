using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaa_SwitchingViewsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewMode
        {
            get
            {
                return _selectedViewModel;
            }
            set
            {
                _selectedViewModel = value;
            }
        }
    }
}
