using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSampleTutorial.ViewModels.Controls;

public partial class MainMenuViewModel : ViewModelBase
{
    private readonly MainWindowViewModel _mainWindowViewModel;

    public MainMenuViewModel(MainWindowViewModel mainWindowViewModel)
    {
        this.IsMainSelected = true;
        _mainWindowViewModel = mainWindowViewModel;
    }

    [ObservableProperty] private bool _isMainSelected;
    [ObservableProperty] private bool _isAboutSelected;

    [RelayCommand]
    private void ShowMain()
    {
        this.IsMainSelected = true;
        this.IsAboutSelected = false;
        _mainWindowViewModel.ShowMain();
    }
    
    [RelayCommand]
    private void ShowAbout()
    {
        this.IsAboutSelected = true;
        this.IsMainSelected = false;
        _mainWindowViewModel.ShowAbout();
    }
}