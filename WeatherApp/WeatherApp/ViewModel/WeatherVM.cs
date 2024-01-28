using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using WeatherApp.ViewModel.Commands;
using WeatherApp.ViewModel.Helpers;

namespace WeatherApp.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        private string query;

        public string Query
        {
            get 
            { 
                return query;
            }
            set
            {
                query = value;
                OnPropertyChanged("Query");
            }
        }

        private CurrentCondition currentCondition;

        public CurrentCondition CurrentCondition
        {
            get { return currentCondition; }
            set 
            { 
                currentCondition = value;
                OnPropertyChanged("CurrentConditions");
            
            }
        }

        private City selectedCity;

        public City SelectedCity
        {
            get { return selectedCity; }
            set 
            { 
                selectedCity = value;
                OnPropertyChanged("SelectedCity");
            }
        }
        public SearchCommand SearchCommand { get; set; }
        public WeatherVM()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {

                SelectedCity = new City
                {
                    LocalizedName = "New York"
                };

                CurrentCondition = new CurrentCondition
                {
                    WeatherText = "Partly Cloudy",
                    Temperature = new Temperature
                    {
                        Metric = new Units
                        {
                            Value = 21
                        }
                    }


                };
            }

            SearchCommand = new SearchCommand(this);
            
        }

        public async void MakeQuery()
        {
            var cities = await AccWeatherHelper.GetCities(Query);

        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
