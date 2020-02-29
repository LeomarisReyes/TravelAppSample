using System;
using System.Drawing;

namespace TravelAppSample.Models
{
    public class TravelSchedule
    {
        public string Time { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string TransportType { get; set; }
        public Color TransportColor { get; set; }

    }
}
