using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exxcellentSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day with the smallest temperature spread is:");

            List<WeatherModel> list = new List<WeatherModel>();

            using (var reader = new StreamReader(@"..\..\InputData\Weather.csv"))
            {
                reader.ReadLine(); //skip first line

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    WeatherModel model = new WeatherModel()
                    {
                        Day = values[0],
                        MxT = float.Parse(values[1]),
                        MnT = float.Parse(values[2]),
                    };

                    list.Add(model);
                }
            }

            WeatherModel minTempModel = list.OrderBy(weather => weather.DifferenzT).FirstOrDefault();

            Console.WriteLine(string.Format("Day: {0}, MaxTmp: {1}, MinTemp: {2}, Difference: {3}", minTempModel.Day, minTempModel.MxT, minTempModel.MnT, minTempModel.DifferenzT));

            Console.WriteLine("\nFootball team with the smallest distance between Goals and Goals Allowed:");

            List<FootballModel> listF = new List<FootballModel>();

            using (var reader = new StreamReader(@"..\..\InputData\Football.csv"))
            {
                reader.ReadLine(); //skip first line

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    FootballModel modelF = new FootballModel()
                    {
                        Team = values[0],
                        Goals = int.Parse(values[5]),
                        GoalsAllowed = int.Parse(values[6]),
                    };

                    listF.Add(modelF);
                }
            }

            FootballModel minGoalsModel = listF.OrderBy(football => football.DifferenzG).FirstOrDefault();

            Console.WriteLine(string.Format("Team: {0}, Goals: {1}, Goals Allowed: {2}, Difference: {3}", minGoalsModel.Team, minGoalsModel.Goals, minGoalsModel.GoalsAllowed, minGoalsModel.DifferenzG));
            Console.ReadKey();

        }
    }
}
