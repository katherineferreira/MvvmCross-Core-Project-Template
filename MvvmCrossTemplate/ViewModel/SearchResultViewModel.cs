using MvvmCross.Plugins.Messenger;
using MvvmCrossTemplate.Contracts.Services;
using MvvmCrossTemplate.Contracts.ViewModel;
using MvvmCrossTemplate.Model;
using MvvmCrossTemplate.Extensions;
using MvvmCrossTemplate.Model.App;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossTemplate.ViewModel
{
    public class SearchResultViewModel : BaseViewModel, ISearchResultViewModel
    {
        private readonly IEmployeeDataService _employeeDataService;
        private string _employeeName;
        private string _employeeCharge;
        private DateTime _employeeStartDate;
        private ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public MvxCommand<Employee> ShowEmployeeDetailsCommand
        {
            get
            {
                return new MvxCommand<Employee>(selectedEmployee =>
                {
                    ShowViewModel<EmployeeDetailViewModel>
                    (new { employeeId = selectedEmployee.EmployeeId });
                });
            }
        }

        public MvxCommand ReloadDataCommand
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    Employees = (await _employeeDataService.SearchEmployee(_employeeName, _employeeCharge, _employeeStartDate)).ToObservableCollection();
                });
            }
        }

        public SearchResultViewModel(IMvxMessenger messenger, IEmployeeDataService employeeDataService) : base(messenger)
        {
            _employeeDataService = employeeDataService;
        }

        protected override async Task InitializeAsync()
        {
            Employees = (await _employeeDataService.SearchEmployee(_employeeName, _employeeCharge, _employeeStartDate)).ToObservableCollection();
        }

        public override async void Start()
        {
            base.Start();

            await ReloadDataAsync();
        }

        public void Init(SearchParameters parameters)
        {
            _employeeName = parameters.EmployeeName;
            _employeeCharge = parameters.EmployeeCharge;
            _employeeStartDate = parameters.EmployeeStartDate;
        }
    }
}
