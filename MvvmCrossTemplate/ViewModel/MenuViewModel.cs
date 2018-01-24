using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using MvvmCrossTemplate.Model.App;
using MvvmCrossTemplate.Utility;
using System;
using System.Collections.ObjectModel;

namespace MvvmCrossTemplate.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {
        public MvxCommand<MenuItem> MenuItemSelectCommand => new MvxCommand<MenuItem>(OnMenuEntrySelect);
        public ObservableCollection<MenuItem> MenuItems { get; }

        public event EventHandler CloseMenu;

        public MenuViewModel(IMvxMessenger messenger) : base(messenger)
        {
            MenuItems = new ObservableCollection<MenuItem>();
            CreateMenuItems();
        }

        private void CreateMenuItems()
        {
            MenuItems.Add(new MenuItem
            {
                Title = "Search Employee",
                ViewModelType = typeof(SearchEmployeeViewModel),
                Option = MenuOption.Employees,
                IsSelected = true
            });

            //MenuItems.Add(new MenuItem
            //{
            //    Title = "My Saved Journeys",
            //    ViewModelType = typeof(SavedJourneysViewModel),
            //    Option = MenuOption.Charges,
            //    IsSelected = false
            //});

            //MenuItems.Add(new MenuItem
            //{
            //    Title = "Settings",
            //    ViewModelType = typeof(SettingsViewModel),
            //    Option = MenuOption.Messages,
            //    IsSelected = false
            //});

            //MenuItems.Add(new MenuItem
            //{
            //    Title = "Settings",
            //    ViewModelType = typeof(SettingsViewModel),
            //    Option = MenuOption.Settings,
            //    IsSelected = false
            //});
        }

        private void OnMenuEntrySelect(MenuItem item)
        {
            ShowViewModel(item.ViewModelType);
            RaiseCloseMenu();
        }

        private void RaiseCloseMenu()
        {
            CloseMenu?.Invoke(this, EventArgs.Empty);
        }
    }
}
