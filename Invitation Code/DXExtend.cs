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
        };
    }
}
