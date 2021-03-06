using BindingTest.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BindingTest
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new MainWindowViewModel();
            this.AttachDevTools();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
