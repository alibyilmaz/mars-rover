using System;
using System.Collections.Generic;
using System.Text;

namespace mars_rover
{
    public class Rover
    {
        public int x; // x coordinate of the current rover position
        public int y; // y coordinate of the current rover position
        public string direction; //cardinal direction of the current rover position

        public Rover(string location) // location 1 2 N
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }
        public void SpinLeft()
        {
            //throw new NotImplementedException();
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();     
            }
        }
        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();

            }
        }

        public void Moveto5_1_E(string roverCommand2)
        {
            char[] instructions2 = roverCommand2.ToCharArray();
            for (int i = 0; i < instructions2.Length; i++)
            {
                switch (instructions2[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void Moveto1_3_N(string roverCommand) // "LMLMLMLMM" or "MMRMMRMMRM"
        {
            //throw new NotImplementedException();
            char[] instructions = roverCommand.ToCharArray();
            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
