using DynamicMenu.Pages;
using Stylet;

namespace Company.WpfApplication1.Pages
{
    public class ShellViewModel : Conductor<IScreen>
    {
        public MainViewModel MainVM { get; set; }

        public ShellViewModel()
        {
            MainVM = new MainViewModel();
            this.ActivateItem(MainVM);
        }
    }
}
