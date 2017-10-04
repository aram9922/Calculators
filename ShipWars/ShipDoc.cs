using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipWars
{
    class ShipDoc
    {
        private int _Nav3, _Nav2, _Nav1;
        private const int SizeX = 10;
        private const int SizeY = 10;
        bool[,] Ship = new bool[SizeX, SizeY];

        public ShipDoc(int Nav1, int Nav2 = 0, int Nav3 = 0)
        {
            _Nav1 = Nav1;
            _Nav2 = Nav2;
            _Nav3 = Nav3;
            //for (int i =0;i<)
        }

        public void Shuffle()
        {
            Random Gen = new Random();
            int x, y;
            x = Gen.Next(0, SizeX - 1);
            y = Gen.Next(0, SizeY - 1);
            Ship[x, y] = true;
        }
    }
}
