using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace SleepWakeSystemII.Models
{
    public class SleepWakeModel
    {
        ISimpleAudioPlayer _player;
        double _volumeValue;

        public Command PlayToneCommand { get; set; }

        public Command PauseCommand { get; set; }

        public Command StopCommand { get; set; }

        public string AlarmFileFullName { get; set; }
        public string WhiteNoiseFileFullName { get; set; }
        public string FormattedAlarmFileName { get; set; }
        public string FormattedWhiteNoiseFileName { get; set; }

        public double VolumeValue
        {
            get => _volumeValue;
            set
            {
                _volumeValue = value;
                _player.Volume = _volumeValue;
            }
        }

        public SleepWakeModel()
        {
            _player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            HookUpCommands();
        }

        private void ExecutePlayToneCommand(string fileName)
        {
            if (_player.IsPlaying)
                _player.Stop();

            _player.Load(GetStreamFromFile(fileName));
            _player.Play();
        }

        private void ExecutePausePlaybackCommand()
        {
            if (_player.IsPlaying)
                _player.Pause();
        }

        private void ExecuteStopPlaybackCommand()
        {
            if (_player.IsPlaying)
                _player.Stop();
        }

        Stream GetStreamFromFile(string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(filename);// ($"SleepWakeSystemII.Droid.Assets.{filename}");

            return stream;
        }

        private void HookUpCommands()
        {
            PlayToneCommand = new Command<string>(ExecutePlayToneCommand);
            PauseCommand = new Command(ExecutePausePlaybackCommand);
            StopCommand = new Command(ExecuteStopPlaybackCommand);
        }

    }
}
