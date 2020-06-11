using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Observer_pattern
{
    public interface ISubject
    {
        void Attach(IObserver o);
        void Deattach(IObserver o);
        void Notify();
    }

    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers;
        private int _temperature;
        public int Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                Notify();
            }
        }
        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver o)
        { }

        public void Deattach(IObserver o)
        { }

        public void Notify()
        {
            _observers.ForEach(o => o.Update(this));
        }
    }

    public interface IObserver
    {
        void Update(ISubject s);
    }

    public class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }
        public NewsAgency(string name)
        { AgencyName = name; }

        public void Update(ISubject s)
        {
            if (s is WeatherStation weatherStation)
            {
                Console.WriteLine(String.Format("{0} is reporting temperature {1}" + 
                                                " degree celcius", AgencyName, weatherStation.Temperature));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            NewsAgency newsAgency1 = new NewsAgency("RalleNews");
            weatherStation.Attach(newsAgency1);
            NewsAgency newsAgency2 = new NewsAgency("MortyNews");
            weatherStation.Attach(newsAgency2);

            weatherStation.Temperature = 2;
            weatherStation.Temperature = 4;
            Console.ReadLine();
        }
    }
}
