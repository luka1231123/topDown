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
    public static int TileFinderX(double xd)
    {
        int x=Convert.ToInt32(xd);        
        x=x-448;
        x=(int)x/18;

        return x;
        
    }
    public static int TileFinderY(double yd)
    {
        int y=Convert.ToInt32(yd);        
        y=y-38;
        y=(int)y/18;

        return y;
    }
}