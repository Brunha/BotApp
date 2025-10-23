using CommunityToolkit.Mvvm.ComponentModel;

namespace DalluiApp.MVVM.Models
{
    public partial class ArtStyle : ObservableObject
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public string imageUrl;
    }
}
