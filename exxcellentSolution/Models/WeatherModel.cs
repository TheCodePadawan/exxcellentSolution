namespace exxcellentSolution
{
    class WeatherModel
    {
        public string Day { get; set; }
        public float MxT { get; set; }
        public float MnT { get; set; }
        public float DifferenzT {
            get
            {
                return MxT - MnT;
            } 
        }
    }
}
