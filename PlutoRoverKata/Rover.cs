using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverKata
{
    public class Rover
    {
        public int PositionY { get; set; }
        public int PositionX { get; set; }
        public string Heading { get; set; }
 

        public Rover()
        {
            PositionX = 0;
            PositionY = 0;
            Heading = "N";
        }

        public void Move(string sentCommands)
        {
            string[] commands = sentCommands.Split(',');

            foreach (var command in commands)
            {
                if (command == "F" && Heading == "N")
                    IncreasePosY();
                if (command == "F" && Heading == "S")
                    DecreasePosY();
                if (command == "F" && Heading == "W")
                    DecreasePosX();
                if (command == "F" && Heading == "E")
                    IncreasePosX();

                if (command == "B" && Heading == "N")
                    DecreasePosY();
                if (command == "B" && Heading == "E")
                    DecreasePosX();
                if (command == "B" && Heading == "S")
                    IncreasePosY();
                if (command == "B" && Heading == "W")
                    IncreasePosX();

                if (command == "L" || command == "R")
                    Turn(command);
                
            }
        }

        public void DecreasePosX()
        {
            if(PositionX > 0)
                PositionX--;
            
        }

        public void DecreasePosY()
        {
            if(PositionY > 0)
                PositionY--;
        }

        public void IncreasePosY()
        {
            PositionY++;
        }

        public void IncreasePosX()
        {
            PositionX++;
        }


        //needs to be dry
        private void Turn(string command)
        {

            if(command == "L")
            {
                switch (Heading)
                {
                    case "N":
                        Heading = "E";
                        break;
                    case "E":
                        Heading = "S";
                        break;
                    case "S":
                        Heading = "W";
                        break;
                    default:
                        break;
                }
            }else if (command == "R")
            {
                switch (Heading)
                {
                    case "N":
                        Heading = "E";
                        break;
                    case "E":
                        Heading = "S";
                        break;
                    case "S":
                        Heading = "W";
                        break;
                    default:
                        break;
                }
            }




        }
    }
}
