using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.Models;

public partial class GrpcMeta : ObservableObject
{
    [ObservableProperty] private string _key;
    [ObservableProperty] private string _value;
}