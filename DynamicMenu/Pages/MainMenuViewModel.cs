using DynamicMenu.Models;
using Stylet;
using System.Collections.ObjectModel;

namespace DynamicMenu.Pages
{
    public class MainMenuViewModel : Screen
    {
        private ObservableCollection<MainMenuItem> _menuItems;
        public ObservableCollection<MainMenuItem> MenuItems
        {
            get { return _menuItems; }
            set { SetAndNotify(ref this._menuItems, value); }
        }

        // ViewModel references
        public ShellViewModel ShellVM { get; }

        // Default constructor
        public MainMenuViewModel()
        {
            MenuItems = new ObservableCollection<MainMenuItem>();
            MenuItems.Add(new MainMenuItem { Title = "Section 1", ViewModel = new Section001ViewModel() });
            MenuItems.Add(new MainMenuItem { Title = "Section 2", ViewModel = new Section002ViewModel() });
            MenuItems.Add(new MainMenuItem { Title = "Section 3", ViewModel = new Section003ViewModel() });
        }

        public MainMenuViewModel(ShellViewModel shellVM) : this()
        {
            ShellVM = shellVM;
        }
    }
}
