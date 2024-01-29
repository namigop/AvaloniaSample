using AvaloniaSampleTutorial.ViewModels.Controls;
using AvaloniaSampleTutorial.ViewModels.Pages;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.ViewModels;


public partial class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        this._mainMenuViewModel = new(this);
        this._mainPageViewModel =  new();
        this._aboutPageViewModel =  new();
        this._currentPageViewModel = this._mainPageViewModel;
        this._appName = "MySampleApp";
    }

    [ObservableProperty] private string _appName;
    [ObservableProperty] private MainMenuViewModel _mainMenuViewModel;
    
    [ObservableProperty] private PageViewModel _currentPageViewModel;
    private readonly MainPageViewModel _mainPageViewModel;
    private readonly AboutPageViewModel _aboutPageViewModel;

    public void ShowMain()
    {
        this.CurrentPageViewModel = this._mainPageViewModel;
    }
    
    public void ShowAbout()
    {
        this.CurrentPageViewModel = this._aboutPageViewModel;
    }
}