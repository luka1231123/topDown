﻿using SFML;
using SFML.Graphics;
using SFML.Window;
using System.Collections.Specialized;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using static topDown.ExtraMethods;

namespace topDown;
public class Program
{
    
    static Window wnd = new Window();
    static vec3 color = new vec3 (0, 0, 0);
    static Random rnd = new Random();
    
    static void Main()
    {
        double c=0;
        double v=0;

        while (wnd.windOpen())
        {
            wnd.Refresh();

            //events here
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    c=Convert.ToDouble(i);
                    c=c/18;
                    v=Convert.ToDouble(j);
                    v=v/18;
                    paintTile(i,j,"",new vec3(((v+c)/2),v,c));
                }
            }

            wnd.Draw();
        }
        
    }
    static void paintTile(int tileX, int tileY, string path, vec3 color)
    {
        
        for(int i=0; i<32; i++){
            for(int j=0;j<32;j++){
                wnd.SetPixel((uint)(i+(tileX*32)+448), (uint)(j+(tileY*32)), color);
            }
        }
    }
}