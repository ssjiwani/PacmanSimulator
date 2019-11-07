using System;
using System.IO;

namespace PacmanSimulator
{
    public static class FileIO
    {
        public static Result ReadPacmanCommands(string path)
        {
            //reads command file and returns commands in string[] or returns exception
            Result result;
            try
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0)
                    result = new Result(true, "Commands loaded successfully", lines);
                else
                    result = new Result(false,"no commands in file");
            }
            catch (FileNotFoundException fex)
            {
                return new Result(false, "Couldn't find pacman command file -> " + fex.Message);
            }
            catch (IOException ioex)
            {
                return new Result(false, "Couldn't read file -> " + ioex.Message);
            }
            catch (FormatException foex)
            {
                return new Result(false, "Unable to parse file data -> " + foex.Message);
            }
            catch (Exception ex)
            {
                return new Result(false, "Unable to load pacman command file -> " + ex.Message);
            }
            return result;
        }
    }
    public class Result
    {
        private bool success;
        private string message;
        private string[] data;
        
        public Result(bool success, string message)
        {
            this.success = success;
            this.message = message;
        }

        public Result(bool success, string message, string[] data)
        {
            this.success = success;
            this.message = message;
            this.Data = data;
        }

        public bool Success { get => success; set => success = value; }
        public string Message { get => message; set => message = value; }
        public string[] Data { get => data; set => data = value; }
    }
}
