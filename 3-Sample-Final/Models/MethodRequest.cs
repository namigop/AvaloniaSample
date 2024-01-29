using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.Models;

public partial class MethodRequest : ObservableObject
{
    [ObservableProperty] private string _methodName;
    [ObservableProperty] private ObservableCollection<GrpcMeta> _headers = new();
    [ObservableProperty] private string _request;
    [ObservableProperty] private DateTimeOffset _deadline;
}