using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aac_ColorChat.WPF.ViewModels
{
    public class MainViewModel
    {
        public ColorChatViewModel ColorChatViewModel { get; }

        public MainViewModel(ColorChatViewModel chatViewModel)
        {
            ColorChatViewModel = chatViewModel;
        }
    }
}
