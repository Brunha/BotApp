using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DalluiApp.MVVM.Models;
using DalluiApp.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalluiApp.MVVM.ViewModels
{
    public partial class GenerationOptionsViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<string> options;
        [ObservableProperty]
        public List<ArtStyle> styles;
        [ObservableProperty]
        object stack;
        public GenerationOptionsViewModel()
        {
            Options = new();
            styles = new List<ArtStyle>();

            FillOptions();
        }
        private void FillOptions()
        {
            Options = new List<string>
        {
            "World",
            "Winter",
            "Land Scapes"
        };

            Styles = new List<ArtStyle>
        {
            new ArtStyle() {Name = "Cartoon", ImageUrl = "cartoon.jpg"},
            new ArtStyle() {Name = "Realistic", ImageUrl = "Realistic.jpg"},
            new ArtStyle() {Name = "Wathercolor Art", ImageUrl = "watercolor.jpg"},
            new ArtStyle() {Name = "Isometric", ImageUrl = "isometric.jpg"},
            new ArtStyle() {Name = "Pop Art", ImageUrl = "popart.jpg"},
            new ArtStyle() {Name = "Surrealism", ImageUrl = "surrealism.jpg"},
            new ArtStyle() {Name = "Minimalism", ImageUrl = "minimalism.jpg"},
            new ArtStyle() {Name = "Funko", ImageUrl = "funko.jpg"},
            new ArtStyle() {Name = "Anime", ImageUrl = "anime.jpg"},
            new ArtStyle() {Name = "Storybook", ImageUrl = "storybook.jpg"},
        };
        }

        [RelayCommand]
        async Task GenerateImage() => await Shell.Current.GoToAsync("/" + nameof(ImageGeneratorView));
    }
}
