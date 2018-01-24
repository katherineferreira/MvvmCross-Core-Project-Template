using System.Threading.Tasks;

namespace MvvmCrossTemplate.Contracts.Services
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonText);
    }
}
