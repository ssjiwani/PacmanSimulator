using System;

/* Shafiq Jiwani
 * Coding Exercise for IE
 */
namespace PacmanSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //program requires commands in form of a text file, take url of file as command line input
            //it will execute all the commands from the file if specified, else it will execute test data file which is placed in project debug\bin\commands.txt

            Pacman pac = new Pacman();
            string filePath = "commands.txt";
            if (args.Length == 1)
            {
                filePath = args[0];
            }
            else
                Console.WriteLine("No file specified in command line. Executing test data file.");

            
            Result r = FileIO.ReadPacmanCommands(filePath);
            if (r.Success)
            {
                foreach (string item in r.Data)
                {
                    if (item != "")
                    {
                        string[] splitLine = item.Split(' ');
                        switch (splitLine[0].ToLower())
                        {
                            case "place":
                                string[] splitIndex = splitLine[1].Split(',');
                                pac.PlacePacman(splitIndex[0], splitIndex[1], splitIndex[2]);
                                continue;
                            case "left":
                                pac.Left();
                                continue;
                            case "right":
                                pac.Right();
                                continue;
                            case "move":
                                pac.Move();
                                continue;
                            case "report":
                                pac.Report();
                                continue;

                        }
                    }
                }
            }
            else
                Console.WriteLine(r.Message);

       
            Console.ReadLine();
        }
    }
}
