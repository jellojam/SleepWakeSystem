using Plugin.SimpleAudioPlayer;
using SleepWakeSystemII.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace SleepWakeSystemII.ViewModels
{
    public class SetViewModel : BaseViewModel
    {
        public ObservableCollection<SleepWakeModel> SleepWakeAlarmModels { get; set; }
        public ObservableCollection<SleepWakeModel> SleepWakeWhiteNoiseModels { get; set; }
        public ObservableCollection<string> AlarmFileNames { get; set; }
        public ObservableCollection<string> WhiteNoiseFileNames { get; set; }

        INavigation _navigation;

        public SetViewModel(INavigation navigation)
        {
            _navigation = navigation;

            AlarmFileNames = new ObservableCollection<string>();
            WhiteNoiseFileNames = new ObservableCollection<string>();
            SleepWakeAlarmModels = new ObservableCollection<SleepWakeModel>();
            SleepWakeWhiteNoiseModels = new ObservableCollection<SleepWakeModel>();
            GetMp3FileNames();
            SetSleepWakeModels();
        }

        void GetMp3FileNames()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var mp3Files = assembly.GetManifestResourceNames();

            foreach (var file in mp3Files)
            {
                if (file.Contains("Alarm"))
                    AlarmFileNames.Add(file);
                else if (file.Contains("Noise"))
                    WhiteNoiseFileNames.Add(file);
            }
        }
        void SetSleepWakeModels()
        {
            foreach (var file in AlarmFileNames)
            {
                var fileNameArray = file.Split('.');
                var fileName = fileNameArray[fileNameArray.GetUpperBound(0) - 1];

                SleepWakeAlarmModels.Add(new SleepWakeModel { AlarmFileFullName = file, FormattedAlarmFileName = fileName });
            }

            foreach (var file in WhiteNoiseFileNames)
            {
                var fileNameArray = file.Split('.');
                var fileName = fileNameArray[fileNameArray.GetUpperBound(0) - 1];

                SleepWakeWhiteNoiseModels.Add(new SleepWakeModel { WhiteNoiseFileFullName = file, FormattedWhiteNoiseFileName = fileName });
            }
        }
    }
}
