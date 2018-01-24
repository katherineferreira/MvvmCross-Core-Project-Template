using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.Messenger;
using MvvmCrossTemplate.Contracts.ViewModel;
using MvvmCrossTemplate.Model.App;
using System;

namespace MvvmCrossTemplate.ViewModel
{
    public class SearchEmployeeViewModel : BaseViewModel, ISearchEmployeeViewModel
    {
        private string _employeeName;
        private string _employeeCharge;
        private DateTime _selectedDate;

        public string EmployeeName
        {
            get { return _employeeName; }
            set
            {
                if (value != _employeeName)
                {
                    _employeeName = value;

                    RaisePropertyChanged(() => EmployeeName);
                }
            }
        }

        public string EmployeeCharge
        {
            get { return _employeeCharge; }
            set
            {
                if (value != _employeeCharge)
                {
                    _employeeCharge = value;

                    RaisePropertyChanged(() => EmployeeCharge);
                }
            }
        }

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                RaisePropertyChanged(() => SelectedDate);
            }
        }

        public SearchEmployeeViewModel(IMvxMessenger messenger) : base (messenger)
        {
            SelectedDate = DateTime.Today;
        }

        public IMvxCommand SearchCommand
        {
            get
            {
                return new MvxCommand(() =>
                    ShowViewModel<SearchResultViewModel>(new SearchParameters
                    {
                        EmployeeName = EmployeeName,
                        EmployeeCharge = EmployeeCharge,
                        EmployeeStartDate = SelectedDate
                    }));
            }
        }

        public override async void Start()
        {
            base.Start();

            await ReloadDataAsync();
        }
    }
}
