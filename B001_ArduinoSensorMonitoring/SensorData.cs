using System;

namespace B001_ArduinoSensorMonitoring
{
    class SensorData
    {
        public string Date { get; set; }   // 속성
        public string Time { get; set; }
        public int Value { get; set; }

        public SensorData(string date, string time, int value)
        {
            this.Date = date;
            this.Time = time;
            this.Value = value;
        }
    }
}
