using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DxLibDLL;

namespace Invitation
{
    public static class DXResources
    {
        public static Dictionary<string, int> Images = new Dictionary<string, int>
        {
            {"Arrow", DX.LoadGraph("data\\arrow.bmp")},
            {"XP",DX.LoadGraph("data\\img-logo-is-canceled.jpg")},
        };

        public static Dictionary<string, int[]> Effects = new Dictionary<string, int[]>
        {
            {"Explode",Enumerable.Range(0,128).Select(x => DX.LoadGraph("data\\Explode" + x + ".bmp")).ToArray()},
            {"Bomb",Enumerable.Range(0,20).Select(x => DX.LoadGraph("data\\e00" + (10 + x / 2) + ".png")).ToArray()},
        };
    }
}
