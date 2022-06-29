using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace RAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings();
            //var g = JsonConvert.SerializeObject(settings);
            //settings.SetTimeSettings("Monday", new Time() { From = DateTime.Now, To = DateTime.Now });
            //settings.SetTimeSettings("Tuesday", new Time() { From = DateTime.Now, To = DateTime.Now });

            //var time = settings.GetTimeSettings("Monday");
            //var time2 = settings.GetTimeSettings("Tuesday");

            settings.SetTime("Monday", "From", "08:30");
        }
    }

    public class Rat
    {

    }

    public class Settings : Config
    {
        private const string JSON_NAME = "Config.json";
        private static string JsonConfig = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            JSON_NAME);

        internal void SetTime(string dayOfWeek, string FromTo, string time)
        {
            if (!TimeSpan.TryParse(time, out TimeSpan resultParse))
                return;
            var setTimer = TimeSpan.Parse(time);

            var g = typeof(WorkTime).GetProperty(dayOfWeek);


            //WorkTime.Add(new WorkTime() { typeof(WorkTime).GetField(dayOfWeek) { } })
        }

        //private static Settings settings;
    }

    public class Function
    {
        
    }

    public sealed class Sound : Function
    {

    }

    public sealed class Photo : Function
    {

    }
}
