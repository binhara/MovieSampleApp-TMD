using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ClassLibrary;
using ClassLibrary.Data;


//using ClassLibrary.Model;

namespace MovieApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {  
        private ObservableCollection<Movie> _topSeries;

        public ObservableCollection<Movie> TopSeries
        {
            get { return _topSeries; }
            set { SetProperty(ref _topSeries, value); }
        }
        
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public MainPageViewModel()
        {
            _topSeries = new ObservableCollection<Movie>();
        }

       
       
        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (TopSeries == null || TopSeries.Count == 0)
            {
                var service = new MovieSharpClient("fa9cfedc2689b490d30f40767fca3fe8");
                var result =  await service.GetUpcomingMoviesAsync(1);
                TopSeries = new ObservableCollection<Movie>(result.Body.Results);

                var result2 = await service.GetUpcomingMoviesAsync(2);
                foreach (Movie movie in result2.Body.Results)
                    TopSeries.Add(movie);
                
                    
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {  

        }

       
    }
}

