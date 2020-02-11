using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApplication.Annotations;

namespace WpfApplication
{
    public class Multimedia : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public enum MediaType
        {
            CD,
            DVD
        };

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value; 
                OnPropertyChanged(nameof(Title));
            }
        }

        private string _artist;
        public string Artist
        {
            get => _artist;
            set
            {
                _artist = value; 
                OnPropertyChanged(nameof(Artist));
            }
        }

        private string _genre;
        public string Genre
        {
            get => _genre;
            set
            {
                _genre = value; 
                OnPropertyChanged(nameof(Genre));
            }
        }

        private MediaType _type;
        public MediaType Type
        {
            get => _type;
            set
            {
                _type = value; 
                OnPropertyChanged(nameof(Type));
            }
        }

        public Multimedia(string title, string artist, string genre, MediaType type)
        {
            _title = title;
            _artist = artist;
            _genre = genre;
            _type = type;
        }

        public Multimedia() { }

        public override string ToString()
        {
            return Title;
        }
    }
}
