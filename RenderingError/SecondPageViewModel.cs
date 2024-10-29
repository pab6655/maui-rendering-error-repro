using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RenderingError
{
    public class SecondPageViewModel : INotifyPropertyChanged
    {
        private readonly INavigation _navigation;
        private readonly Action<string> _callback;
        private string _selectedItem;

        public SecondPageViewModel(INavigation navigation, Action<string> callback)
        {
            _navigation = navigation;
            _callback = callback;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string[] Monkeys => new string[] { "Baboon", "Capuchin Monkey", "Blue Monkey", "Squirrel Monkey", "Golden Lion Tamarin", "Howler Monkey", "Japanese Macaque" };

        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged();

                    _callback?.Invoke(value);

                    _navigation.PopModalAsync();
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
