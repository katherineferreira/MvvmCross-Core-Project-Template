using MvvmCross.Plugins.Messenger;
using MvvmCrossTemplate.Contracts.Services;
using MvvmCrossTemplate.Contracts.ViewModel;

namespace MvvmCrossTemplate.ViewModel
{
    public class EmployeeDetailViewModel : BaseViewModel, IEmployeeDetailViewModel
    {
        private readonly IEmployeeDataService _employeeDataService;
        public EmployeeDetailViewModel(IMvxMessenger messenger,
            IEmployeeDataService employeeDataService) : base(messenger)
        {
            _employeeDataService = employeeDataService;
        }
    }
}
