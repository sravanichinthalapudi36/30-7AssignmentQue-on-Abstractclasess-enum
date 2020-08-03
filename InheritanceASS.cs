using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace consoleFirstApp
{
    class Game
    {
        public static int noOfPlayers;
        public static string country;
        public Game()
        {

        }
        public Game(int _noOfPlayers, String _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;

        }
        public void Display()
        {
            Console.WriteLine("no of players are{0}", noOfPlayers);
            Console.WriteLine("country name is {0}", country);
        }
        public static DateTime Now { get; }
    }
    class Cricket : Game
    {
        public static String coachName;
        public Cricket()
        {

        }
        public Cricket(String _country, int _noOfPlayers, String _coachName) :
            base(_noOfPlayers, _country)
        {
            coachName = _coachName;

        }
        public void DisplayCric(String country, int noOfPlayers, String coachName)
        {
    
            Console.WriteLine("country: {0} no of players:{1} coach Name is:{2}", country, noOfPlayers, coachName);
        }
        public void Worldcup()
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine("Australia have won Cricket Worldcup:" + dt.Year);
        }

    }
    class FootBall : Game
    {
        public static string LeageName;
        public FootBall()
        {

        }
        public FootBall(String _country, int _noOfPlayers, String _LeageName) : base(_noOfPlayers, _country)
        {
            LeageName = _LeageName;
        }
        public void DisplayFootB(String country, int noOfPlayers, String LeageName)
        {

            Console.WriteLine("country: {0} noof players:{1} League Name is:{2}", country, noOfPlayers, LeageName);


        }
        public void Worldcup()
        {

            DateTime dt = DateTime.Now;
            Console.WriteLine("Spain have won Football Worldcup:" + dt.Year);
        }
    }

    class AssQue2
    {
        static void Main()
        {
            Game g = new Game(11, "srajvj");
            g.Display();


            Cricket c = new Cricket();
            Console.WriteLine("---------CRICKET INFORMATION----------");
            c.DisplayCric("india", 11, "john write");
            c.DisplayCric("Austrila", 21, "john Bachanss");

            Console.WriteLine("---------FOOTBALL INFORMATION----------");
            FootBall f = new FootBall();
            f.DisplayFootB("spain", 14, "spanish Leage");
            f.DisplayFootB("England", 13, "English Premiur League");

            Cricket india = new Cricket();
            Cricket australia = new Cricket();

            FootBall spain = new FootBall();
            FootBall england = new FootBall();

            australia.Worldcup();
            spain.Worldcup();

            Console.ReadLine();
        }
    }
}
