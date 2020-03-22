using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace addCrunch
{
    public class VideoFileApi
    {
        //protected static string ffmpegBin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\bin\\");
        protected static string ffmpegBin = Path.Combine("c:\\temp\\addCrunch\\", "ffmpeg\\bin\\");
        public static void ExtractFrames(string inputMovie, string saveTo)
        {
            System.IO.Directory.CreateDirectory(saveTo);
            runCommand(
                Path.Combine(ffmpegBin, "ffmpeg.exe"),
                //string.Format("-i \"{0}\" -f image2 \"{1}\\%5d.png\" -y -vsync 0", inputMovie, saveTo)
                string.Format("-i \"{0}\" -f image2 \"{1}\\%5d.png\" -y -vsync cfr", inputMovie, saveTo)
                //string.Format("-i \"{0}\" \"{1}\\%5d.png\" -y -vsync 2", inputMovie, saveTo)
                );
        }

        public static void ExtractSound(string inputMovie, string saveTo)
        {
            System.IO.Directory.CreateDirectory(saveTo);
            runCommand(
                Path.Combine(ffmpegBin, "ffmpeg.exe"),
                string.Format("-i \"{0}\"  \"{1}\\sound.wav\" -y",inputMovie,saveTo)
                );
        }

        public static string ExtractFramerate(string inputMovie)
        {
            //- v error - select_streams v: 0 - show_entries stream = duration -of default= noprint_wrappers = 1:nokey = 1 input.mp4
            return runCommandWithReturn(
                Path.Combine(ffmpegBin, "ffprobe.exe"),
                //string.Format("-v 0 -of compact=p=0 -select_streams 0 -show_entries stream=r_frame_rate \"{0}\" ", inputMovie)
                string.Format("-v 0 -of compact=p=0 -select_streams 0 -show_entries -show_streams \"{0}\" ", inputMovie)
                );
            //return("29,970029");
        }

        public static string ExtractDuration(string inputMovie)
        {
            //- v error - select_streams v: 0 - show_entries stream = duration -of default= noprint_wrappers = 1:nokey = 1 input.mp4
            return runCommandWithReturn(
                Path.Combine(ffmpegBin, "ffprobe.exe"),
                string.Format("-v 0 -of compact=p=0 -select_streams 0 -show_entries stream=duration \"{0}\" ", inputMovie)
                );
            //return("29,970029");
        }

        public static void CombineDirectoryUsingFramerate(string inputDirectory, string saveTo, string framerate)
        {
            string directory = Path.Combine(Path.GetDirectoryName(saveTo), "\\" + Path.GetFileNameWithoutExtension(saveTo));
            System.IO.Directory.CreateDirectory(directory);
            //ffmpeg -i video.mp4 -i audio.wav -c:v copy -c:a aac -shortest output.mp4
            //runCommand(string.Format("-i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v copy -c:a aac -shortest -y \"{1}\"", inputDirectory, saveTo));
            runCommand(
                Path.Combine(ffmpegBin, "ffmpeg.exe"),
                string.Format("-framerate {2} -i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v libx264 -pix_fmt yuv420p -c:a aac \"{1}\" -y", inputDirectory, saveTo, framerate)
                //string.Format("-framerate {2} -i \"{0}\\%5d.png\" -c:v libx264 -pix_fmt yuv420p -y \"{1}\"", inputDirectory, saveTo, framerate)
                //string.Format("-i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v libx264 -pix_fmt yuv420p -c:a aac -y -r {2} \"{1}\"", inputDirectory, saveTo, framerate)
                //string.Format("-i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v libx264 -pix_fmt yuv420p -profile:v baseline -c:a aac -shortest -y \"{1}\"", inputDirectory, saveTo, framerate)
                );
        }

        //public static void CombineDirectoryUsingLength(string inputDirectory, string saveTo, string duration)
        //{
        //    string directory = Path.Combine(Path.GetDirectoryName(saveTo), "\\" + Path.GetFileNameWithoutExtension(saveTo));
        //    System.IO.Directory.CreateDirectory(directory);
        //    //ffmpeg -i video.mp4 -i audio.wav -c:v copy -c:a aac -shortest output.mp4
        //    //runCommand(string.Format("-i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v copy -c:a aac -shortest -y \"{1}\"", inputDirectory, saveTo));
        //    runCommand(
        //        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\bin\\ffmpeg.exe"),
        //        string.Format("-i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v libx264 -pix_fmt yuv420p -profile:v baseline -c:a aac -t {2} -shortest -y \"{1}\"", inputDirectory, saveTo, duration)
        //        );
        //}

        //public static void CombineDirectoryUsingLengthAndStartAndNumerOfFrames(string inputDirectory, string saveTo, string duration, int startFrame, int numberOfFrames)
        //{
        //    string directory = Path.Combine(Path.GetDirectoryName(saveTo), "\\" + Path.GetFileNameWithoutExtension(saveTo));
        //    System.IO.Directory.CreateDirectory(directory);
        //    runCommand(
        //        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg\\bin\\ffmpeg.exe"),
        //        string.Format("-i \"{0}\\%5d.png\" -i \"{0}\\sound.wav\" -c:v libx264 -pix_fmt yuv420p -start_number {3:d} -vframes {4:d} -profile:v baseline -c:a aac -t {2} -shortest -y \"{1}\"", inputDirectory, saveTo, duration, startFrame, numberOfFrames)
        //        );
        //}

        static void runCommand(string filename, string command)
        {
            //* Create your Process
            Process process = new Process();
            process.StartInfo.FileName = filename;
            //process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.WorkingDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "output");
            //process.StartInfo.Arguments = "/c DIR";
            process.StartInfo.Arguments = command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            //* Set ONLY ONE handler here.
            ////* Set your output and error (asynchronous) handlers
            //process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            //* Start process
            process.Start();
            //* Read one element asynchronously
            process.BeginErrorReadLine();
            //process.BeginOutputReadLine();
            //* Read the other one synchronously
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            process.WaitForExit();
        }

        static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            //* Do your stuff with the output (write to console/log/StringBuilder)
            Console.WriteLine(outLine.Data);
        }

        static string runCommandWithReturn(string filename, string command)
        {
            //* Create your Process
            Process process = new Process();
            process.StartInfo.FileName = filename;
            process.StartInfo.Arguments = command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            //* Start process
            process.Start();
            //* Read the output (or the error)
            string err = process.StandardError.ReadToEnd();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            if (!string.IsNullOrEmpty(err))
                throw new Exception(err);
            return (output);
        }

    }
}
