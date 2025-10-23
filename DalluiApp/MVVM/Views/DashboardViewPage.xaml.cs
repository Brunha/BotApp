using CommunityToolkit.Mvvm.ComponentModel;
using DalluiApp.MVVM.Models;
using DalluiApp.MVVM.ViewModels;
using System.Collections.ObjectModel;

namespace DalluiApp.MVVM.Views;

public partial class DashboardViewPage : ContentPage
{
    //public ObservableCollection<Profile> ProfilesDisplay = new();

    //public ObservableCollection<GeneratedImage> GeneratedImages = new();
    public DashboardViewPage(DashboardViewPageViewModel dvm)
    {
        InitializeComponent();

        dvm.LoadDataStart();

        //ProfilesData(dvm); GeneratedImagesData(dvm);

        BindingContext = dvm;
    }

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync(nameof(GenerationOptionsView));
    //}

    //private async void ProfilesData(DashboardViewPageViewModel vm)
    //{
    //    ProfilesDisplay = await vm.RetrieveProfilessData();
    //}

    //private async void GeneratedImagesData(DashboardViewPageViewModel vm)
    //{
    //    GeneratedImages = await vm.RetrieveGeneratedImagesData();
    //}
}