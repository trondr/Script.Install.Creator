using System.Windows;
using Script.Install.Creator.Library.Module.Views;

namespace Script.Install.Creator.Library.Module.Common.UI
{
    public abstract class ViewModelBase : DependencyObject
    {
        public MainWindow MainWindow { get; set; }
    }
}
