using Pr38_TheMovies.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Fields and Properties
        ShowingRepository showingRepository;
        BookingRepository bookingRepo;

        public ObservableCollection<ShowingViewModel> ShowingViewModels { get; set; }

        private ShowingViewModel selectedShowing;

        public ShowingViewModel SelectedShowing
        {
            get { return selectedShowing; }
            set 
            { 
                selectedShowing = value;
                OnPropertyChanged("SelectedShowing");
            }
        }
        #endregion

        public MainViewModel()
        {
            showingRepository = new ShowingRepository();
            ShowingViewModels = new ObservableCollection<ShowingViewModel>();
            foreach (Showing s in showingRepository.GetAll())
            {
                ShowingViewModels.Add(new ShowingViewModel(s));
            }
        }



        #region INotifyPropertyChanged
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
