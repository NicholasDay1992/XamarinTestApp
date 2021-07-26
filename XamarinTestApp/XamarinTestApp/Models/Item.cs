using System;

namespace XamarinTestApp.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public double fromDistance { get; set; }
        public double toDistance { get; set; }
        public string fromUnit { get; set; }
        public string toUnit { get; set; }
    }
}