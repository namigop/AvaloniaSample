using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.Models;

public partial class MethodResponse : ObservableObject
{
    [ObservableProperty] private string _response;
}