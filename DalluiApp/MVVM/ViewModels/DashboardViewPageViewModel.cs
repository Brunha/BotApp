using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DalluiApp.MVVM.Models;
using DalluiApp.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalluiApp.MVVM.ViewModels
{
    public partial class DashboardViewPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Profile> profiles;
        [ObservableProperty]
        public ObservableCollection<GeneratedImage> generatedImages;

        public DashboardViewPageViewModel()
        {
            profiles = new ObservableCollection<Profile>();
            generatedImages = new ObservableCollection<GeneratedImage>();
        }

        public void LoadDataStart() { LoadData(); }

        private void LoadData()
        {
            Profiles = new ObservableCollection<Profile>
        {
            new Profile
            {
                Name = "Héctor",
                ProfileImage = "profile1.jpg",
                NoPhotos = 12
            },
            new Profile
            {
                Name = "Maddy",
                ProfileImage = "profile2.jpg",
                NoPhotos = 5,
            },
            new Profile
            {
                Name = "Henry",
                ProfileImage = "profile3.jpg",
                NoPhotos= 25
            },
        };

            GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage
            {
                ImagePath = "dashboard1.jpg",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic, hill, mountain, trees, blue sky"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard2.jpg",
                MainKeyword = "Mountains",
                Keywords = new List<string>
                {
                    "Landscape, photorealistic, dawn, mountains"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard3.jpg",
                MainKeyword = "Robot",
                Keywords = new List<string>
                {
                    "AI, robotic, human, light, metal"
                }
            },
        };
        }

        //public async Task<ObservableCollection<Profile>> RetrieveProfilessData()
        //{
        //     return Profiles;
        //}

        //public async Task<ObservableCollection<GeneratedImage>> RetrieveGeneratedImagesData()
        //{
        //     return GeneratedImages;
        //}


        [RelayCommand]
        async Task NextPage() => await Shell.Current.GoToAsync(nameof(GenerationOptionsView));
    }
}

