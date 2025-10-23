using CommunityToolkit.Mvvm.ComponentModel;

namespace DalluiApp.MVVM.Models
{
    public partial class Profile : ObservableObject
    {
        [ObservableProperty]
        public string profileImage;
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public int noPhotos;
    }
}
