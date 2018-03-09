using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtterPongGame
{
    class PongScene : Scene
    {
        public PongScene()
        {
            var testSquare = new Entity(512, 320, Image.CreateRectangle(32, 32, Color.White));
            var mov = new BasicMovement(1000, 1000, 100);
            mov.Axis = Global.player.Controller.Axis(Global.Controls.Axis);
            testSquare.AddComponent(mov);

            Add(testSquare);
        }

        public override void Render()
        {
            base.Render();
            Draw.Circle(Input.MouseScreenX, Input.MouseScreenY, 7, Color.Gold);
            //Console.WriteLine("hello hello testing");
        }
    }
}
