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
        public char Heading { get; set; }
 

        public Rover()
        {
            PositionX = 0;
            PositionY = 0;
            Heading = 'N';
        }

        /// <summary>
        /// moves rover based on commands F - front, B - backwards
        /// L - turn left, R - turn right
        /// </summary>
        /// <param name="sentCommands"></param>
        public void Move(string sentCommands)
        {
            char[] commands = sentCommands.ToCharArray();

            foreach (var command in commands)
            {
                if (command == 'F' && Heading == 'N')
                    IncreasePosY();
                if (command == 'F' && Heading == 'S')
                    DecreasePosY();
                if (command == 'F' && Heading == 'W')
                    DecreasePosX();
                if (command == 'F' && Heading == 'E')
                    IncreasePosX();

                if (command == 'B' && Heading == 'N')
                    DecreasePosY();
                if (command == 'B' && Heading == 'E')
                    DecreasePosX();
                if (command == 'B' && Heading == 'S')
                    IncreasePosY();
                if (command == 'B' && Heading == 'W')
                    IncreasePosX();

                if (command == 'L' || command == 'R')
                    Turn(command);
                
            }
        }


        /// <summary>
        /// decreases rover's position in X axis
        /// </summary>
        public void DecreasePosX()
        {
            if(PositionX > 0)
                PositionX--;
            
        }

        /// <summary>
        /// decreases rover's position in Y axis
        /// </summary>
        public void DecreasePosY()
        {
            if(PositionY > 0)
                PositionY--;
        }

        /// <summary>
        /// increases rover's position in Y axis
        /// </summary>
        public void IncreasePosY()
        {
            PositionY++;
        }

        /// <summary>
        /// increases rover's position in X axis
        /// </summary>
        public void IncreasePosX()
        {
            PositionX++;
        }


        //needs to be dry && simplified
        private void Turn(char command)
        {

            if(command == 'L')
            {
                switch (Heading)
                {
                    case 'N':
                        Heading = 'W';
                        break;
                    case 'W':
                        Heading = 'S';
                        break;
                    case 'S':
                        Heading = 'E';
                        break;
                    default:
                        break;
                }
            }else if (command == 'R')
            {
                switch (Heading)
                {
                    case 'N':
                        Heading = 'E';
                        break;
                    case 'E':
                        Heading = 'S';
                        break;
                    case 'S':
                        Heading = 'W';
                        break;
                    default:
                        break;
                }
            }




        }
    }
}
