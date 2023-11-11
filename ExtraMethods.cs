using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topDown;

internal class ExtraMethods
{
    public double aspectRatio = 16.0 / 9.0;

    public static bool ikp(Keyboard.Key key)
    {
        bool boolx = false;
        if (Keyboard.IsKeyPressed(key))
        {
            boolx = true;
        }
        return boolx;
    }
}