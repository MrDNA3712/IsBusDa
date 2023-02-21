namespace Is_Bus_da
{
    internal class DepartureInfo
    {
        public string Line { get; }
        public string destination { get; }
        public DateTime departure { get; }
        public DateTime actualDeparture { get; }
        public int delay { get; }


        public DepartureInfo(string line, string destination, DateTime departure, DateTime actualDeparture, int delay)
        {
            this.Line = line;
            this.destination = destination;
            this.departure = departure;
            this.actualDeparture = actualDeparture;
            this.delay = delay;
        }
    }
}
