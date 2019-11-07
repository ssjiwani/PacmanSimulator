using System;

namespace PacmanSimulator
{
    public enum FACE { EAST, WEST, NORTH, SOUTH };
    public class Pacman
    {
        //pacman grid dimensions
        private const int MAX_X = 5;
        private const int MAX_Y = 5;

        private int x;
        private int y;
        private FACE currentFace;
        private bool isPlaced;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public FACE CurrentFace { get => currentFace; set => currentFace = value; }
        public bool IsPlaced { get => isPlaced; set => isPlaced = value; }

        public Pacman()
        {
            //initializing values to South West position and face to EAST. If input file have REPORT before valid placing pacman it will show warning 
            //of pacman not been placed.
            this.X = 0; this.Y = 0; IsPlaced = false; currentFace = FACE.EAST;
        }

        public void PlacePacman(string xInd, string yInd, string face)
        {
            //parsing file PLACE input and initializing class variables
            if (int.TryParse(xInd, out int x) && int.TryParse(yInd, out int y) && Enum.TryParse(face, out FACE currFace))
            {
                if (x >= 0 && x < MAX_X && y >= 0 && y < MAX_Y)//checking if grid indexes are not out of grid
                {
                    this.X = x;
                    this.Y = y;
                    this.CurrentFace = currFace;
                    this.IsPlaced = true;
                }
                else
                    IsPlaced = false;
            }
            else
                IsPlaced = false;
        }

        public void Move()
        {
            //checking if pacman is placed on grid
            //logic according to pacman face direction
            //checking if its not falling off the grid
            if (IsPlaced)
            {
                if (this.CurrentFace == FACE.EAST)
                {
                    if (X + 1 < MAX_X)
                        X += 1;
                }
                if (this.CurrentFace == FACE.WEST)
                {
                    if (X - 1 >= 0)
                        X -= 1;
                }
                if (this.CurrentFace == FACE.NORTH)
                {
                    if (Y + 1 < MAX_Y)
                        Y += 1;
                }
                if (this.CurrentFace == FACE.SOUTH)
                {
                    if (Y - 1 >= 0)
                        Y -= 1;
                }
            }

        }

        public void Left()
        {
            //rotating pacman face to 90 degrees left
            if (IsPlaced)
            {
                switch (this.CurrentFace)
                {
                    case FACE.EAST:
                        this.CurrentFace = FACE.NORTH;
                        break;
                    case FACE.NORTH:
                        this.CurrentFace = FACE.WEST;
                        break;
                    case FACE.WEST:
                        this.CurrentFace = FACE.SOUTH;
                        break;
                    case FACE.SOUTH:
                        this.CurrentFace = FACE.EAST;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Right()
        {
            //rotating pacman face to 90 degrees right
            if (IsPlaced)
            {
                switch (this.CurrentFace)
                {
                    case FACE.EAST:
                        this.CurrentFace = FACE.SOUTH;
                        break;
                    case FACE.NORTH:
                        this.CurrentFace = FACE.EAST;
                        break;
                    case FACE.WEST:
                        this.CurrentFace = FACE.NORTH;
                        break;
                    case FACE.SOUTH:
                        this.CurrentFace = FACE.WEST;
                        break;
                    default:
                        break;
                }
            }
        }

        public void Report()
        {
            //printing result
            if (IsPlaced)
            {
                Console.WriteLine(this.X + "," + this.Y + "," + this.CurrentFace);
            }
            else
                Console.WriteLine("Pacman not placed correctly");
        }
        
    }
}
