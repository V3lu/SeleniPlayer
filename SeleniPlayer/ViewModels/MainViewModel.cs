
using SeleniPlayer.Entities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SeleniPlayer.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    private readonly SeleniPlayerDBContext _dbContext;

    public MainViewModel(SeleniPlayerDBContext context)
    {
        _dbContext = context;
    }



}
