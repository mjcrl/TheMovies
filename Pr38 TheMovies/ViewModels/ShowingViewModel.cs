using Pr38_TheMovies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr38_TheMovies.ViewModels
{
    public class ShowingViewModel : INotifyPropertyChanged
    {
        private Showing showing;
        public string TheStringofTheShowing
        {
            get
            {
                return showing.ToString();
            }
        }
        public ShowingViewModel(Showing showing)
        {
            this.showing = showing;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
