using CommunityToolkit.Mvvm.ComponentModel;

namespace DalluiApp.MVVM.Models
{
    public partial class GeneratedImage : ObservableObject
    {
        [ObservableProperty]
        public string imagePath;
        [ObservableProperty]
        public string mainKeyword;

        [ObservableProperty]
        public List<string> keywords;
    }
}
