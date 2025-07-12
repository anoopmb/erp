using CommunityToolkit.Mvvm.ComponentModel;

namespace ErpApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "ERP Dashboard";
    }
}
