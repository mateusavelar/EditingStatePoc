using System.ComponentModel;

namespace EditingStatePoc
{
    public class MainWindowModel : INotifyPropertyChanged
    {
        private bool _isEditing;

        public bool IsEditing
        {
            get { return _isEditing; }
            set
            {
                _isEditing = value;
                NotifyPropertyChanged(nameof(IsEditing));
            }
        }

        private string _someText;

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                NotifyPropertyChanged(nameof(SomeText));
            }
        }

        private void NotifyPropertyChanged(string propertyName) => PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}