using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.Models;

public partial class MethodRequest : ObservableObject
{
    [ObservableProperty] private string _methodName = "";
    [ObservableProperty] private ObservableCollection<GrpcMeta> _headers;
    [ObservableProperty] private string _request = "";
    [ObservableProperty] private DateTimeOffset _deadline = DateTimeOffset.Now;

    public MethodRequest()
    {
        _headers = new();
        _headers.Add(new GrpcMeta(){ Key = "SampleKey", Value = "Sample Value"});
    }
}