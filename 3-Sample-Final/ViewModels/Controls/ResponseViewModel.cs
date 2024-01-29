using AvaloniaSampleTutorial.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.ViewModels.Controls;

public partial class ResponseViewModel : ViewModelBase
{
    [ObservableProperty] private MethodResponse _methodResponse = new();
}