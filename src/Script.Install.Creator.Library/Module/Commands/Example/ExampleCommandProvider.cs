using System.Windows;
using Common.Logging;
using Script.Install.Creator.Library.Infrastructure;
using Script.Install.Creator.Library.Module.ViewModels;
using Script.Install.Creator.Library.Module.Views;

namespace Script.Install.Creator.Library.Module.Commands.Example
{
    public class ExampleCommandProvider : CommandProvider, IExampleCommandProvider
    {
        private readonly MainWindow _mainWindow;        
        private readonly ILog _logger;

        public ExampleCommandProvider(MainWindow mainWindow, ILog logger)
        {
            _mainWindow = mainWindow;
            _logger = logger;
        }


        public int Create(string targetRootFolder)
        {
            var returnValue = 1;
            _logger.Info("Showing main window as an example user interface.");
            var application = new Application();
            application.Run(_mainWindow);
            var viewModel = _mainWindow.View.ViewModel as MainViewModel;
            if (viewModel != null)
            {
                _logger.Info("Getting info from the user interface and do something with it: " + viewModel.ProductDescription);
            }
            else
            {
                _logger.Fatal("Fatal error. MainView model returned from dialog was null");
                returnValue = 2;
            }            
            return returnValue;
        }
    }
}