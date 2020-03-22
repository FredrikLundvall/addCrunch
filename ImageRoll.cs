using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addCrunch
{
    public class ImageRoll
    {
        protected string _imagePath;
        protected string _extension;
        protected int _currentFrameNumber;
        protected int _firstFrameNumber;
        protected int _lastFrameNumber;

        public ImageRoll(string imagePath)
        {
            _imagePath = imagePath;
            _extension = "png";
            _currentFrameNumber = 1;
            UpdateFrameBoundaries();
        }

        public void UpdateFrameBoundaries()
        {
            _firstFrameNumber = CheckFirstFrameNumber();
            _lastFrameNumber = CheckLastFrameNumber();
        }

        public int GetFirstFrameNumber()
        {
            return _firstFrameNumber;
        }

        public int GetLastFrameNumber()
        {
            return _lastFrameNumber;
        }

        public int GetCurrentFrameNumber()
        {
            return _currentFrameNumber;
        }

        public void SetCurrentFrameNumber(int currentFrameNumber)
        {
            _currentFrameNumber = currentFrameNumber;
        }

        //public 

        public string GetCurrentFrameFilename()
        {
            return GetFilenameForFrameNumber(_currentFrameNumber);
        }

        protected string GetFilenameForFrameNumber(int frameNumber)
        {
            return string.Format("{0}\\{1:00000}.{2}", _imagePath, frameNumber, _extension);
        }

        protected int CheckFirstFrameNumber()
        {
            var list = Directory.EnumerateFiles(_imagePath);
            try
            {
                return Int32.Parse(Path.GetFileNameWithoutExtension(Directory.EnumerateFiles(_imagePath).OrderBy(filename => filename).First()));
            }
            catch
            {
                return 0;
            }
        }

        protected int CheckLastFrameNumber()
        {
            try
            {
                var filenameList = Directory.EnumerateFiles(_imagePath).OrderByDescending(filename => filename);
                string lastFilename = Path.GetFileNameWithoutExtension(filenameList.First());
                if (lastFilename == "sound")
                    return Int32.Parse(Path.GetFileNameWithoutExtension(filenameList.Skip(1).First()));
                else
                    return Int32.Parse(lastFilename);
             }
            catch
            {
                return 0;
            }
        }
    }
}
