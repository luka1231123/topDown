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
    static menuWindow mwnd = new menuWindow();
    private static menuWindow mwndT = new menuWindow();
    static vec3 color = new vec3 (0, 0, 0);
    static Random rnd = new Random();
    
    static void Main()
    {
        double c=0;
        double v=0;
        
        mwnd.Init(500,400,"1");
        mwnd.Close();
        mwnd.Init(900,400,"2");
        mwndT.Init(600,400,"3");
        while (wnd.windOpen())
        {
            wnd.Refresh();
            mwnd.Refresh();
            mwndT.Refresh();
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
}