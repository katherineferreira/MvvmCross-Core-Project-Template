using MvvmCross.Core.ViewModels;

namespace MvvmCrossTemplate
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            // Login functionality can be added with IUserDataService

            ShowViewModel<MainViewModel>();
        }
    }
}
