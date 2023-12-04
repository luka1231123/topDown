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
    static vec3[,] vec3array = new vec3[32,32];
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
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j <32 ; j++)
                {
                    c=Convert.ToDouble(i);
                    c=c/32;
                    v=Convert.ToDouble(j);
                    v=v/32;
                    paintTile(i,j,"",new vec3(((v+c)/2),v,c));
                }
            }

            wnd.Draw();
        }
        
    }
    static void paintTile(int tileX, int tileY, string path, vec3 color)
    {
        
        for(int i=0; i<18; i++){
            for(int j=0;j<18;j++){
                wnd.SetPixelArray((i+(tileX*18)+448), (j+(tileY*18)), color);
            }
        }
    }
    static int TileFinderX(double xd)
    {
        int x=Convert.ToInt32(xd);        
        x=x-448;
        x=(int)x/18;

        return x;
        
    }
    static int TileFinderY(double yd)
    {
        int y=Convert.ToInt32(yd);        
        y=y-38;
        y=(int)y/18;

        return y;
    }
}