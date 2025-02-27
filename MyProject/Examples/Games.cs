using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Examples.Examples
{
    abstract class Games
    {
        public abstract void gameMusic();

        public void loadingScreen()
        {
            Console.WriteLine("Oyun yükleniyor...");
        }

    }

    class Valorant : Games
    {
        public override void gameMusic()
        {
            Console.WriteLine("Valorant Game Music Playing...");
        }
    }
}
