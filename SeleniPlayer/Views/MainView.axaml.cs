using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace SeleniPlayer.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        Celcius.TextChanged += OnTextChange;
    }

    void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (double.TryParse(Celcius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fa.Text = F.ToString("0.0");
        }
        else
        {
            Celcius.Text = "0";
            Fa.Text = "0";
        }

    }

    void OnTextChange(object? sender, TextChangedEventArgs e)
    {
        if (double.TryParse(Celcius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fa.Text = F.ToString("0.0");
        }
        else
        {
            Celcius.Text = "0";
            Fa.Text = "0";
        }
    }
}