using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;



namespace topDown;

public class menuWindow
{
    public Image image { get; set; }
    public Texture texture { get; set; }
    public Sprite sprite { get; set; }
    public RenderWindow tempWin { get; set; }
    public static vec2 WH = new vec2();
    public vec3[,] screenArray;
    public void Init(int x, int y, string title)
    {
        vec3[,] screenArray = new vec3[x,y];
        
        WH.x = x;
        WH.y = y;
        tempWin = new RenderWindow(new SFML.Window.VideoMode((uint)WH.x, (uint)WH.y), title);
        tempWin.Closed += (sender, e) => tempWin.Close();
        
    }

    public void Close()
    {
        tempWin.Close();
    }
    public void Refresh()
    {
        tempWin.DispatchEvents();
        tempWin.Clear();
        image= new Image((uint)WH.x, (uint)WH.y);
        
    }
    public void Draw()
    {
        for(int i=0;i<WH.x;i++){
            for(int j=0;j<WH.y;j++){
                SetPixel((uint)(i), (uint)(j), screenArray[i,j]);
            }
        }
        texture = new Texture(image);
        sprite = new Sprite(texture);
        tempWin.Draw(sprite);
        tempWin.Display();
    }
    public bool windOpen()
    {
        bool bl = true;
        bl = tempWin.IsOpen;
        return bl;
    }
    public void SetPixelArray(int x, int y,vec3 color)
    {
        screenArray[x,y]=color;
    }
    public void SetPixel(uint x, uint y,vec3 color)
    {
        double cx = color.x * 255.999;
        double cy = color.y * 255.999;
        double cz = color.z * 255.999;
        Color clr = new Color((byte)(cx), (byte)(cy), (byte)(cz));
        image.SetPixel(x,y,clr);
    }
}