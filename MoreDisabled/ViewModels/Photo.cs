using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MoreDisabled.ViewModels
{
    public class Photo :INotifyPropertyChanged
    {
        private string _url;
        private int _likes;
        private int _dislikes;
        public Photo()
        {
            Comments = new MvxObservableCollection<string>();
        }
        public int Likes
        {
            get => _likes;
            set
            {
                _likes = value;
                OnPropertyChanged();
            }
        }
        MvxObservableCollection<string> Comments { get; }
        public int Dislikes {
            get => _dislikes;
            set
            {
                _dislikes = value;
                OnPropertyChanged();
            }
        }

        public string Url
        {
            get => _url;
            set => _url = value;
        }

        public ICommand IncrementLikes => new MvxCommand(() =>
        {
            Likes++;
        });
        public ICommand DecrementLikes => new MvxCommand(() =>
        {
            Dislikes++;
        });
        public ICommand InsertComment => new MvxCommand(() =>
        {
            //komentarz
        });
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        
    }
}
