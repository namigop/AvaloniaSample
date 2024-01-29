using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSampleTutorial.Models;

public partial class Node: ObservableObject
{
    public ObservableCollection<Node> Items { get; } = new();
    
    [ObservableProperty] private bool _isExpanded;
    [ObservableProperty] private string _name;
}