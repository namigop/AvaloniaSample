using System;
using System.Xml;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;
using AvaloniaEdit.Highlighting;
using AvaloniaEdit.Highlighting.Xshd;
using AvaloniaSampleTutorial.ViewModels.Controls;

namespace AvaloniaSampleTutorial.Views.Controls;

public partial class RequestView : UserControl
{
    public RequestView()
    {
        InitializeComponent();
        this.SetupSyntaxHighlighting();
        this.DataContextChanged += OnDataContextChanged;
    }

    private void OnDataContextChanged(object? sender, EventArgs e)
    {
        var vm = this.DataContext as RequestViewModel;
        this.Editor.Text = vm.MethodRequest.Request;
    }

    private void OnTextChanged(object? sender, EventArgs e)
    {
        var editor = sender as TextEditor;
        var vm = this.DataContext as RequestViewModel;
        vm.MethodRequest.Request = editor.Text;
    }
    private void SetupSyntaxHighlighting() {
        using var resource =
            typeof(RequestView)
                .Assembly.
                GetManifestResourceStream("AvaloniaSampleTutorial.Resources.json.xshd");
        if (resource != null) {
            using var reader = new XmlTextReader(resource);
            this.Editor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);
        }
    }
}