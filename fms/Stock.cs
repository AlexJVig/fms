using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace fmsServer
{
    public class Stock : INotifyPropertyChanged
    {
        private double _latestQuote;

        public int Id { get; set; }

        public double LatestQuote
        {
            get
            {
                return _latestQuote;
            }
            set
            {
                if (value != _latestQuote)
                {
                    _latestQuote = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DateTime LastUpdateTimestamp { get; set; }

        public Stock(int id, double latestQuote)
        {
            Id = id;
            LatestQuote = latestQuote;
            LastUpdateTimestamp = DateTime.Now;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
