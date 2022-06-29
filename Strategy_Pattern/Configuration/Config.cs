using System.Collections.Generic;

namespace RAT
{
    public class Config
    {
        public string Token { get; set; }
        public long ChatId { get; set; }

        public bool HideRun { get; set; }
        public bool AutoRun { get; set; }

        public List<WorkTime> WorkTime = new List<WorkTime>();
    }
}
