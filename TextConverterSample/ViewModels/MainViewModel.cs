using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextConverterSample.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty] string abc;
        public MainViewModel()
        {
            Abc = "HIHIHI";
        }

        int aa = 1;
        [RelayCommand]
        private void aaaa()
        {
            if (aa == 1)
            {
                Abc = "HIHIHI1";
                aa = 0;
            }

            else
            {
                Abc = "HIHIHI";
                aa = 1;
            }
        }
    }
}
