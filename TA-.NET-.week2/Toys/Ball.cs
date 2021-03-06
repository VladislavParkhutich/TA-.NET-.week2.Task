﻿using System;

namespace TA_.NET_.week2.Toys
{
    [Serializable]
    class Ball : Toy
    {
        private string name = "Yamata-1";

        public Ball(string color, uint price, uint tall)
            : base(color, price, tall)
        { }

        //Overrided method prints doll's description
        public override void PrintDescription()
        {
            Console.WriteLine("Ball: " + name);
            Console.WriteLine("-price:" + Price);
            Console.WriteLine("-tall:" + Tall);
            Console.WriteLine("-color:" + Color);
            Console.WriteLine("-available:" + Available);
        }
    }
}
