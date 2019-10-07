using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SleepWakeSystemII
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        //ISimpleAudioPlayer player;
        public MainPage()
        {
            InitializeComponent();
            //var stream = GetStreamFromFile("Gentle-wake-alarm-clock.mp3");
            //player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            //player.Load(stream);

            //InitControls();
        }

        //void InitControls()
        //{
        //    sliderVolume.Value = player.Volume;

        //    btnPlay.Clicked += BtnPlayClicked;
        //    btnPause.Clicked += BtnPauseClicked;
        //    btnStop.Clicked += BtnStopClicked;

        //    sliderVolume.ValueChanged += SliderVolumeValueChanged;
        //    sliderPosition.ValueChanged += SliderPostionValueChanged;

        //}

        //private void SliderPostionValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    if (sliderPosition.Value != player.Duration)
        //        player.Seek(sliderPosition.Value);
        //}

        //private void SliderVolumeValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    player.Volume = sliderVolume.Value;
        //}

        //private void BtnStopClicked(object sender, EventArgs e)
        //{
        //    player.Stop();
        //}

        //private void BtnPauseClicked(object sender, EventArgs e)
        //{
        //    player.Pause();
        //}

        //void BtnPlayClicked(object sender, EventArgs args)
        //{
        //    player.Play();

        //    sliderPosition.Maximum = player.Duration;
        //    sliderPosition.IsEnabled = player.CanSeek;

        //    Device.StartTimer(TimeSpan.FromSeconds(0.5), UpdatePosition);

        //}

        //bool UpdatePosition()
        //{
        //    lblPosition.Text = $"Postion: {(int)player.CurrentPosition} / {(int)player.Duration}";

        //    sliderPosition.ValueChanged -= SliderPostionValueChanged;
        //    sliderPosition.Value = player.CurrentPosition;
        //    sliderPosition.ValueChanged += SliderPostionValueChanged;

        //    return player.IsPlaying;
        //}

        //Stream GetStreamFromFile(string filename)
        //{
        //    var assetDir = @"SleepWakeSystemII.Droid.Assets.";
        //    var assembly = Assembly.GetExecutingAssembly();
        //    var stream = assembly.GetManifestResourceStream($"{assetDir}{filename}");

        //    return stream;
        //}
    }
}
