using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiApp1.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MauiApp1.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged
{
    private readonly AppDbContext _dbContext;
    public ObservableCollection<Customer> Customers { get; set; }

    public MainPageViewModel(AppDbContext _dbContext)
    {
        this._dbContext = _dbContext;
        var customers = _dbContext.Customers.ToList();
        Customers = new ObservableCollection<Customer>(customers);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}