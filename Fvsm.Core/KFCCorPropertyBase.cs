//----------------------------------------------------------------------------
// Project    :   FFmpegVsSlnMaker
// Module     :   Fvsm.Core
// File       :   KFCCorPropertyBase.cs
//----------------------------------------------------------------------------
// Revisions  :
// 16-11-2018 Krizsán Péter             - Original version
//----------------------------------------------------------------------------
using System.ComponentModel;

namespace Fvsm.Core
{
    /// <summary>
    /// The base class of the bindable objects. Helps to
    /// implement the Model-View-ViewModel (MVVM) architecture.
    /// </summary>
    public class KFCCorPropertyBase : INotifyPropertyChanged
    {
        /// <summary>
        /// By subscribing to this event the client receives notifications about property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                return;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
