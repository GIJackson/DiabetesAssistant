using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace DiabetesAssistant.ViewModel;

/*Generic class for current and future ViewModels*/

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    public bool IsNotBusy => !IsBusy;
}
