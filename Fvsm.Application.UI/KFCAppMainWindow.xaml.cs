//----------------------------------------------------------------------------
// Project    :   FFmpegVsSlnMaker
// Module     :   Fvsm.Application.UI
// File       :   KFCAppMainWindow.xaml.cs
//----------------------------------------------------------------------------
// Revisions  :
// 16-11-2018 Krizsán Péter             - Original version
//----------------------------------------------------------------------------
using System.Windows;
using Fvsm.Application.ViewModel;

namespace Fvsm.Application.UI
{
    /// <summary>
    /// Interaction logic for KFCAppMainWindow.xaml
    /// </summary>
    public partial class KFCAppMainWindow : Window
    {
        /// <summary>
        /// Class responsible for the main window.
        /// </summary>
        public KFCAppMainWindow()
        {
            InitializeComponent();
            DataContext = new KFCAppVmdViewModelMainWindow();
        }
    }
}
