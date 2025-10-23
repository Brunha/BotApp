using DalluiApp.MVVM.Models;
using DalluiApp.MVVM.ViewModels;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace DalluiApp.MVVM.Views;

public partial class GenerationOptionsView : ContentPage
{
    //public List<string> Options { get; set; }
    //public List<ArtStyle> Styles { get; set; }s
    public GenerationOptionsView(GenerationOptionsViewModel givm)
    {
        InitializeComponent();
        //FillOptions();

        BindingContext = givm;

        //        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("EditorCustomization", (handler, view) =>
        //        {
        //#if ANDROID
        //            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);

        //#endif
        //        });

        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID

            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS || MACCATALYST

#elif WINDOWS

#endif

        });

    }

    //private void FillOptions()
    //{
    //    Options = new List<string>
    //    {
    //        "World",
    //        "Winter",
    //        "Land Scapes"
    //    };

    //    Styles = new List<ArtStyle>
    //    {
    //        new ArtStyle() {Name = "Cartoon", ImageUrl = "cartoon.jpg"},
    //        new ArtStyle() {Name = "Realistic", ImageUrl = "Realistic.jpg"},
    //        new ArtStyle() {Name = "Wathercolor Art", ImageUrl = "watercolor.jpg"},
    //        new ArtStyle() {Name = "Isometric", ImageUrl = "isometric.jpg"},
    //        new ArtStyle() {Name = "Pop Art", ImageUrl = "popart.jpg"},
    //        new ArtStyle() {Name = "Surrealism", ImageUrl = "surrealism.jpg"},
    //        new ArtStyle() {Name = "Minimalism", ImageUrl = "minimalism.jpg"},
    //        new ArtStyle() {Name = "Funko", ImageUrl = "funko.jpg"},
    //        new ArtStyle() {Name = "Anime", ImageUrl = "anime.jpg"},
    //        new ArtStyle() {Name = "Storybook", ImageUrl = "storybook.jpg"},
    //    };
    //}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync("/" + nameof(ImageGeneratorView));
    //}
}