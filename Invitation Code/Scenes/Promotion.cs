using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invitation.Scenes
{
    public class Promotion : IScene
    {
        NetConnector cntr;
        public Promotion(NetConnector _cntr)
        {
            cntr = _cntr;
        }

        public void Work()
        {
        }
    }
}
