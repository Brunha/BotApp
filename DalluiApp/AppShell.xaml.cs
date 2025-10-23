using DalluiApp.MVVM.Views;
using Microsoft.Maui.Controls;

namespace DalluiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(GenerationOptionsView), typeof(GenerationOptionsView));

            Routing.RegisterRoute(nameof(ImageGeneratorView), typeof(ImageGeneratorView));
        }
    }
}