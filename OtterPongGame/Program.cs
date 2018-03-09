using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;
using static OtterPongGame.Global;

namespace OtterPongGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Otter Pong", 1000, 750);

            Global.player = game.AddSession("Player1");

            Global.player.Controller.AddAxis(Controls.Axis, Axis.CreateWASD());
            Global.player.Controller.AddButton(Controls.Action);
            Global.player.Controller.Button(Controls.Action).AddKey(Key.Space);

            game.FirstScene = new PongScene();
            game.Start();
        }
    }
}
