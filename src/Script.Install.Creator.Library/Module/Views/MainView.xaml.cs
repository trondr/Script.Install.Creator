using Script.Install.Creator.Library.Module.Common.UI;
using Script.Install.Creator.Library.Module.ViewModels;

namespace Script.Install.Creator.Library.Module.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : ViewBase
    {
        public MainView(MainViewModel viewModel)
        {
            this.ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
