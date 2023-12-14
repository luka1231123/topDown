﻿using SFML;
using SFML.Graphics;
using SFML.Window;
using System.Collections.Specialized;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
 using topDown.Main;
 using static topDown.ExtraMethods;

namespace topDown;
public class Program
{
    
    private static MainLog MainApp = new MainLog();
    private static Background backApp = new Background();

    public static bool running = true;

    static void Main()
    {
        Thread mainThread = Thread.CurrentThread;
        Thread threadBackground = new Thread(new ThreadStart(backApp.FullScreen));
        threadBackground.Start();

        while (MainApp.WindOpen())
        {
            running = true;

            MainApp.Draw();
            MainApp.Refresh();
            
        }
        if(!MainApp.WindOpen())
        {
            running = false;
            threadBackground.Join();
            Console.WriteLine("thread is dead");
        }
    }

}