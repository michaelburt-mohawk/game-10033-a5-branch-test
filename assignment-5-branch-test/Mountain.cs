using System.Numerics;

namespace MohawkGame2D
{
    public class Mountain
    {
        Texture2D mountain;
        public void Setup()
        {
            mountain = Graphics.LoadTexture("Assets/mountain.jpg");
        }

        public void Update()
        {
            Graphics.Scale = 1;
            Graphics.Rotation = 0;
            Graphics.Draw(mountain, new Vector2(0, 0));
        }

    }
}
