using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MoreDisabled.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MvxObservableCollection<Photo> Photos { get; }

        public MainViewModel()
        {
            Photos = new MvxObservableCollection<Photo>
            {
                new Photo
                {
                    Url = "http://www.efantastyka.pl/files/filmy/shrek.jpg",
                    Likes = 10,
                    Dislikes = 10000
                },
                 new Photo
                {
                    Url = "http://www.efantastyka.pl/files/filmy/shrek.jpg",
                    Likes = 10,
                    Dislikes = 10000
                }
            };
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}