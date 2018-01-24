using MvvmCross.Core.ViewModels;
using MvvmCrossTemplate.Contracts.ViewModel;

namespace MvvmCrossTemplate.ViewModel
{
    public class MainViewModel : MvxViewModel, IMainViewModel
    {
        public MainViewModel()
        {

        }

        public void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }

        public void ShowSearchCustomers()
        {
            ShowViewModel<SearchEmployeeViewModel>();
        }
    }
}
