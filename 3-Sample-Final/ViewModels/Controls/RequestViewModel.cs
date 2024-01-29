using System.Threading.Tasks;
using AvaloniaSampleTutorial.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSampleTutorial.ViewModels.Controls;

public partial class RequestViewModel : ViewModelBase
{
    public RequestViewModel(string method)
    {
        this.MethodRequest = new MethodRequest() { MethodName = method };
    }

    [ObservableProperty] private MethodRequest _methodRequest;

    [RelayCommand]
    private async Task Run()
    {
    }
    
    [RelayCommand]
    private void AddHeader()
    {
        var count = this.MethodRequest.Headers.Count;
        this.MethodRequest.Headers.Add(new GrpcMeta(){ Key= $"Key{count}", Value = $"Value{count}" });
    }
}