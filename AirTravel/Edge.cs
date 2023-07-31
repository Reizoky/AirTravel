namespace AirTravel
{
    public struct Edge
    {
        public int startPeak;
        public int endPeak;
        public int cost;
        public string name;

        public Edge(int _StartPeak, int _EndPeak, int Cost, string Name)
        {
            startPeak = _StartPeak;
            endPeak = _EndPeak;
            cost = Cost;
            name = Name;
        }
    }
}