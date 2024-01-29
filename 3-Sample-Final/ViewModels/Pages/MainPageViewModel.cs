using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
using AvaloniaSampleTutorial.Models;
using System.Linq;
using AvaloniaSampleTutorial.ViewModels.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.ViewModels.Pages;

public partial class MainPageViewModel:PageViewModel
{
    public MainPageViewModel()
    {
        var temp = new HierarchicalTreeDataGridSource<Node>(this.Items) {
            Columns = {
                new HierarchicalExpanderColumn<Node>(new TemplateColumn<Node>("", "Column1CellTemplate",
                        null, 
                        new GridLength(1, GridUnitType.Star)), 
                    x => x.Items, 
                    x => x.Items.Any(), 
                    x => x.IsExpanded),
                new TemplateColumn<Node>("", "Column2CellTemplate", null, 
                    new GridLength(1, GridUnitType.Auto))
            }
        };

        this.GrpcClientTree = temp;
        
        //hard coding things for now. This is just an example anyway
        this.Items.Add(new () { Name="http://foobar/123" });
        this.Items[0].Items.Add(new(){ Name = "SayHello"});

        this.Request = new RequestViewModel("SayHellp");
        this.Response = new ResponseViewModel();
    }

    public ObservableCollection<Node> Items { get; } = new();

    public override string Header { get; } = "Main";
    public HierarchicalTreeDataGridSource<Node> GrpcClientTree { get; }

    [ObservableProperty] private RequestViewModel _request;
    [ObservableProperty] private ResponseViewModel _response;
}