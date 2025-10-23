using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalluiApp.MVVM.ViewModels
{
    public partial class ImageGeneratorViewModel: ObservableObject
    {
        [ObservableProperty]
        List<string> imagesRndm;
        [ObservableProperty]
        Random rndm = new();
        [ObservableProperty]
        public string imageValue;


        public ImageGeneratorViewModel()
        {
            imagesRndm = new List<string>();

            List<Task> multipleTask = new();

            multipleTask.Add(Task.Run(() => ImageData()));

            multipleTask.Add(Task.Run(() => GenerateRandomImage()));

            Task.WhenAll(multipleTask);

            //ImageData();

            //ImageRndm();
        }
        void ImageData()
        {
            ImagesRndm = new List<string>
        {
            {"cartoon.jpg"},
            {"anime.jpg"},
            {"dashboard3.jpg"},
            {"profilesquare.jpg"},
            {"profile1.jpg"},
            {"profile2.jpg"},
            {"profile3.jpg"},
            {"funko.jpg"},
            {"realistic.jpg"},
        };
        }
        public async Task GenerateRandomImage()
        {
            await ImageCalculator();
        }

        private async Task ImageCalculator()
        {
            await Task.Delay(0);
            var t = Task.Run(() => { ImageValue = ImagesRndm[Rndm.Next(ImagesRndm.Count)]; });

            //  Value = t.ToString();
            //  Value = await Task.Run ImagesRndm[Rndm.Next(ImagesRndm.Count)];
        }

        //public async Task<string> ReturnValue()
        //{
        //    await Task.Delay(0);
        //    return ImageValue.ToString();
        //}

        [RelayCommand]
        async Task Finnish() => await Shell.Current.GoToAsync("../..");
    }
}

