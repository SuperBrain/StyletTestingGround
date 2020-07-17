using Stylet;

namespace DynamicMenu.Pages
{
    public class ShellViewModel : Conductor<IScreen>.StackNavigation
    {
        // StatusBar
        private string _statusMessage1;
        public string StatusMessage1
        {
            get { return _statusMessage1; }
            set { SetAndNotify(ref this._statusMessage1, value); }
        }
        // ViewModel references
        public MainMenuViewModel MainMenuVM { get; }

        // Default constructor
        public ShellViewModel()
        {
            StatusMessage1 = "Ready";
            MainMenuVM = new MainMenuViewModel(this);
            this.ActivateItem(MainMenuVM);
        }
    }
}
