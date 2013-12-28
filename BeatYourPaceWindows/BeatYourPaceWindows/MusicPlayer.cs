using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Phone.BackgroundAudio;

namespace BeatYourPaceWindows
{
    class MusicPlayer
    {
        private static bool _initialised;
        static int currentTrackIndex = 0;


        private static List<AudioTrack> _trackList = new List<AudioTrack>

        // For loop to create new audiotrack objects?
            { new AudioTrack(new Uri("Ring01.wma", UriKind.Relative),
                "Test Track",
                "Windows Phone",
                "Windows Phone Ringtones",
                new Uri("shared/media/Ring01.jpg",UriKind.Relative))

     };

        //Following code from windows phone guide
               public AudioPlayer()
        {
            if (!_initialised)
            {
                _initialised = true;
                // Subscribe to the managed exception handler
                Deployment.Current.Dispatcher.BeginInvoke(delegate
                {
                    Application.Current.UnhandledException += AudioPlayer_UnhandledException;
                });
            }
        }

                /// Code to execute on Unhandled Exceptions
        private void AudioPlayer_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }





    }
}