//----------------------------------------------------------------------------
// N O L D U S   I N F O R M A T I O N   T E C H N O L O G Y   B . V .
//----------------------------------------------------------------------------
// Project    :   FFmpegVsSlnMaker
// Module     :   Fvsm.Application.ViewModel
// File       :   KFCAppVmdViewModelMainWindow.cs
//----------------------------------------------------------------------------
// Revisions  :
// 28-11-2018 Péter Krizsán             - Original version
//----------------------------------------------------------------------------
using Fvsm.Core;

namespace Fvsm.Application.ViewModel
{
    /// <summary>
    /// The view model of our main window.
    /// </summary>
    public class KFCAppVmdViewModelMainWindow : KFCCorPropertyBase
    {
        #region Fields

        private string m_ffmpegFolder;

        #endregion Fields

        #region Public properties

        /// <summary>
        /// Holds the folder that contains the FFMPEG source code.
        /// </summary>
        public string FFMpegFolder
        {
            get => m_ffmpegFolder;
            set
            {
                m_ffmpegFolder = value;
                OnPropertyChanged(nameof(FFMpegFolder));
            }
        }

        #endregion Public properties

        #region Constructors

        /// <summary>
        /// Default constructor of the main window's view model.
        /// </summary>
        public KFCAppVmdViewModelMainWindow()
        {
            FFMpegFolder = @"D:\FFMPEG-Source";
        }

        #endregion Constructors
    }
}
