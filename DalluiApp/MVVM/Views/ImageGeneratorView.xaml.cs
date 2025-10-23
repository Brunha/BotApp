using DalluiApp.MVVM.ViewModels;
using System.Diagnostics;

namespace DalluiApp.MVVM.Views;

public partial class ImageGeneratorView : ContentPage
{
    //  Show how much time passed after the execution or generation of the image
    Stopwatch watch = new();
    //string[] randomImages = { "anime.jpg", "cartoon.jpg", "dashboard3.jpg", "funko.jpg", "profile1.jpg", "profile2.jpg", "profile3.jpg", "profilesquare.jpg", "realistic.jpg" };
    //Random rndm = new Random();
    public ImageGeneratorView(ImageGeneratorViewModel imageRndm)
    {
        InitializeComponent();

        // ImageRndm = new();
        BindingContext = imageRndm;
    }

    //  Action that does first thing app starts
    protected override async void OnAppearing()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));  //  Start to count after this delay was passed
        watch.Start();

        var cts = new CancellationTokenSource();

        using (var timer = new PeriodicTimer(TimeSpan.FromSeconds(1)))  //  Executing a Task from every second
        {
            //  Setting a try section, to deal with cancelationToken
            try
            {
                var counter = 0;
                while (await timer.WaitForNextTickAsync(cts.Token)) //  Setting what happens every tick its executed
                {
                    if (counter >= 3)
                    {
                        cts.Cancel();
                    }

                    var seconds = watch.Elapsed.Seconds;    //  Retrieve how much seconds as passed, to display
                    lblTimer.Text = seconds.ToString();
                    counter++;
                }
            }
            catch(TaskCanceledException)
            {
                //imageRndm = randomImages[rndm.Next(randomImages.Length)];
                await StopGeneration();
            }
        }
    }

    private async Task StopGeneration()
    {
        watch.Stop();

        await Task.Delay(2000);

        //await ImageRndm.GenerateRandomImage();

        //  ImageValue = await ImageRndm.ReturnValue();

        lottie.IsAnimationEnabled = false;
        lottie.IsVisible = false;
        imageBorder.IsVisible = true;
        imageAnimation.IsVisible = true;

        //  Executes a series of animations
        await Task.WhenAny(
            imageAnimation.ScaleTo(1.1, 1000),
            imageAnimation.FadeTo(0, 1000),
            borderTimer.ScaleTo(1, 1000),
            borderTimer.FadeTo(1, 1000)
            );


        await borderTimer.FadeTo(0, 300);
        await btnFinish.ScaleTo(1, 1000);

    }

    //    private async void btnFinish_Clicked(object sender, EventArgs e)
    //    {
    //        await Shell.Current.GoToAsync("../..");
    //    }
}