using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace MoreDisabled.ViewModels
{
    public abstract class BaseViewModel<TParamatr> : MvxViewModel<TParamatr>
    {

    }
    public class MainViewModel : BaseViewModel<string>
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
        public ICommand PhotoSelectedCommand => new PhotoSelectedCommand(this);
    }
    }
    public class PhotoSelectedCommand : MvxCommand
    {
        private readonly INavigatingObject _navigatingObject;
        public PhotoSelectedCommand(INavigatingObject navigatingObject) 
        {
            navigatingObject = navigatingObject;
        }
    private void Execute(Photo photo)
    {
        _navigatingObject.Navigate<PhotoDetailsViewModel,PhotoId>(new PhotoId { Id = photo.Id})
    }

    }
public class PhotoId
{
    public int Id { get; set; }
}
    internal class PhotoDetailsViewModel : BaseViewModel<int>
    {
        public override void Prepare(int parametr)
        {
            base.Prepare();
        }
    }
public class PhotoDetailsActivity : MvxViewModelAc
       

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