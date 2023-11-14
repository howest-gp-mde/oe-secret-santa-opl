using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang.Annotation;
using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

[assembly:Xamarin.Forms.Dependency(typeof(Mde.SecretSanta.Droid.Services.DroidInformerService))]

namespace Mde.SecretSanta.Droid.Services
{
    public class DroidInformerService : IInFormerService
    {
        public void InformUser()
        {
            if(Build.VERSION.SdkInt >= BuildVersionCodes.S)
            {
                VibratorManager manager = (VibratorManager)Android.App.Application.Context.GetSystemService(Context.VibratorManagerService);
                Vibrator vibrator = manager.DefaultVibrator;
                vibrator.Vibrate(VibrationEffect.CreateOneShot(500, VibrationEffect.DefaultAmplitude));
            }
            else
            {
                Vibrator vibrator = (Vibrator)Android.App.Application.Context.GetSystemService(Context.VibratorService);
                vibrator.Vibrate(VibrationEffect.CreateOneShot(500, VibrationEffect.DefaultAmplitude));
            }
        }
    }
}