using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SeleniPlayer.Entities;
using SeleniPlayer.ViewModels;
using SeleniPlayer.Views;
using System;

namespace SeleniPlayer;

public partial class App : Application
{
    public static IServiceProvider Services { get; private set; }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

        var services = new ServiceCollection();
        services.AddDbContext<SeleniPlayerDBContext>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SeleniPlayerDB;Trusted_Connection=True;"));
        services.AddTransient<MainWindow>();

        Services = services.BuildServiceProvider();
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var MainWindowSeervice = Services.GetRequiredService<MainWindow>();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = MainWindowSeervice
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = MainWindowSeervice
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

}