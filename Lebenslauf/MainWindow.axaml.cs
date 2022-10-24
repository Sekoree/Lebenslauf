using System;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaUI.PrintToPDF;

namespace Lebenslauf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void InputElement_OnDoubleTapped(object? sender, RoutedEventArgs e)
        {
            try
            {
                Print.ToFile("Lebenslauf.pdf", this);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}