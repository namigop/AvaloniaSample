using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSampleTutorial.ViewModels.Controls;

public partial class MainMenuViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainWindowViewModel;

    public MainMenuViewModel(MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;
    }

    [RelayCommand]
    private void ShowMain()
    {
        _mainWindowViewModel.ShowMain();
    }
    
    [RelayCommand]
    private void ShowAbout()
    {
        _mainWindowViewModel.ShowAbout();
    }
}