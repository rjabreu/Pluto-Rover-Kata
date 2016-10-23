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
            string[] commands = sentCommands.Split();

            foreach (var command in commands)
            {
                if (command.Equals("F") )
                {

                }
            }
        }

        public void IncreasePosY()
        {
            PositionY++;
        }

        public void IncreasePosX()
        {
            PositionX++;
        }

    }
}
