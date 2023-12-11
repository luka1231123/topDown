﻿using SFML;
using SFML.Graphics;
using SFML.Window;
using System.Collections.Specialized;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
 using topDown.Main;
 using static topDown.ExtraMethods;

namespace topDown;
public class Program
{
    
    private static MainLog MainApp = new MainLog();
    private static Background backApp = new Background();
    static void Main()
    {
        while (MainApp.WindOpen())
        {
            backApp.fullScreen();
            MainApp.Draw();
            MainApp.Refresh();
        }
    }

}