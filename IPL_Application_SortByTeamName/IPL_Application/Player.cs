using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application
{
    class Player : Team 

    {
        int id;
        string name;
        int age;
        string battingStyle;
        string bowlingStyle;

        public Player()
        {
        }

       /* public Player( int id, string name, int age, string battingStyle, string bowlingStyle)
        {
            

            Id = id;
            Name = name;
            Age = age;
            BattingStyle = battingStyle;
            BowlingStyle = bowlingStyle;
        }*/

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string BattingStyle { get => battingStyle; set => battingStyle = value; }
        public string BowlingStyle { get => bowlingStyle; set => bowlingStyle = value; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6}",TeamName,Country, id, name, age, battingStyle, bowlingStyle);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Player p = (Player)obj;
            return this.battingStyle.Equals(p.battingStyle);
        }

        public static Player createPlayer(string playerDetails)
        {
            string[] s = playerDetails.Split(',');
            Player p = new Player(s[0],s[1],int.Parse(s[2]),s[3],int.Parse(s[4]),s[5],s[6]);
            return p;
        }

           

       


        //own Constructor
        public Player(string teamName, string country, int id, string name, int age, string battingStyle, string bowlingStyle)
            :base( teamName, country)
        {

            Id = id;
            Name = name;
            Age = age;
            BattingStyle = battingStyle;
            BowlingStyle = bowlingStyle;
        }
    }

    
}
