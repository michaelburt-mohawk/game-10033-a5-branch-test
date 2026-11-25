using System;
using System.Collections.Generic;
using System.Text;

namespace MohawkGame2D
{
    public class Sounds
    {
        Sound shoot;
        public void Setup()
        {
            shoot = Audio.LoadSound("Assets/Shoot.wav");
        }
    }
}
