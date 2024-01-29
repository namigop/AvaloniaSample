using System.Threading.Tasks;
using AvaloniaSampleTutorial.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaSampleTutorial.ViewModels.Controls;

public partial class RequestViewModel : ViewModelBase
{
    private readonly ResponseViewModel _responseViewModel;

    public RequestViewModel(string method, ResponseViewModel responseViewModel)
    {
        _responseViewModel = responseViewModel;
        this.MethodRequest = new MethodRequest() { MethodName = method };
        var sampleRequest = @"{
                ""Request"": {
                    ""Name"": ""Hello John"",
                }
            }";

        this.MethodRequest.Request = sampleRequest;
    }

    [ObservableProperty] private MethodRequest _methodRequest;

    [RelayCommand]
    private async Task Run()
    {
        var client = new SampleGrpcClient();
        var sampleResp = client.Invoke(this.MethodRequest);
        this._responseViewModel.MethodResponse = sampleResp;
    }

    [RelayCommand]
    private void AddHeader()
    {
        var count = this.MethodRequest.Headers.Count;
        this.MethodRequest.Headers.Add(new GrpcMeta() { Key = $"Key{count}", Value = $"Value{count}" });
    }
}