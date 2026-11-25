// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Player p1 = new Player();
        public void Setup()
        {
            Window.SetTitle("GitHub Branches Test");
            Window.SetSize(800, 600);

            p1.Setup();
        }


        public void Update()
        {
            Window.ClearBackground(Color.White);

            p1.Update();
        }
    }

}
