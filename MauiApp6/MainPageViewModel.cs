using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {

        }


        [RelayCommand]
        public async Task DisplayPopup()
        {
            //this.popupService.ShowPopup<NewContent1>();
            //await Shell.Current.CurrentPage.ShowPopupAsync(new NewContent1());
            var popupService = IPlatformApplication.Current.Services.GetService<IPopupService>();
            popupService.ShowPopup<PopupViewModel>();
        }
    }
}
