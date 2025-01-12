using System.ComponentModel;

namespace FoodApp.ViewModels;

public interface IViewModel : INotifyPropertyChanged
{
}

public class FoodListViewModel : IViewModel
{
    public event PropertyChangedEventHandler? PropertyChanged;
    
    
}