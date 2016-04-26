using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Models
{
    public class Player
    {

        private string playerName;
        private int playerPoints;

            public string PlayerName
            {
                get
                {
                    return playerName;
                }

                set
                {
                    playerName = value;
                }
            }

            public int PlayerPoints
            {
                get
                {
                    return playerPoints;
                }

                set
                {
                   playerPoints = value;
                }
            }

            public Player()
            {
            }

            public Player(string name, int points)
            {
                this.PlayerName = name;
                this.PlayerPoints = points;
            }
        }
    }

