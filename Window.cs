using SFML.Graphics;
using SFML.System;

namespace topDown;

public abstract class Window
{
    ExtraMethods exm = new ExtraMethods();
    public uint xWidth { get; set; }
    public uint yHeight { get; set; }
    public string title { get; set; }

    protected List<Text> Textlist = new List<Text>();
    
    protected static vec3[,] screenArray = new vec3[1024,576];

    public Image image { get; set; }
    public Texture texture { get; set; }
    public Sprite sprite { get; set; }
    protected RenderWindow win { get; set; }
    protected Window(int x, int y, string titty)
    {
        xWidth = (uint)x;
        yHeight = (uint)(xWidth / exm.aspectRatio);
        title = titty;
        if (y != -1)
        {
            yHeight = (uint)y;
        }
        image = new Image(xWidth, yHeight);
        texture = new Texture(image);
        sprite = new Sprite(texture);
        win = new RenderWindow(new SFML.Window.VideoMode(xWidth, yHeight), title);
        win.Closed += (sender, e) => win.Close();
        for(int i=0;i<xWidth;i++){
            for(int j=0;j<yHeight;j++){
                screenArray[i,j]=new vec3(0,0,0);
            }
        }

        win.SetFramerateLimit(60);
    }
    public void SetPixelArray(int x, int y,vec3 color)
    {
        screenArray[x,y]=color;
    }
    protected void SetPixel(uint x, uint y,vec3 color)
    {
        double cx = color.x * 255.999;
        double cy = color.y * 255.999;
        double cz = color.z * 255.999;
        Color clr = new Color((byte)(cx), (byte)(cy), (byte)(cz));
        image.SetPixel(x,y,clr);
    }
    public void Refresh()
    {
        win.DispatchEvents();
        win.Clear();
        image= new Image(xWidth, yHeight);

        
    }
    public void Draw(List<Text> sfmlText)
    {
        for(int i=0;i<1024;i++){
            for(int j=0;j<576;j++){
                SetPixel((uint)(i), (uint)(j), screenArray[i,j]);
            }
        }
        texture = new Texture(image);
        sprite = new Sprite(texture);
        win.Draw(sprite);
        foreach (var text in sfmlText)
        {
            win.Draw(text);
        }
        win.Display();
    }
    public bool WindOpen()
    {
        return win.IsOpen;
    }
    public void DrawText(RenderWindow window, string fontname, string text, Vector2f position, Color color)
    {
        Font font = new Font(fontname);
        Text sfmlText = new Text(text, font);
        sfmlText.Position = position;
        sfmlText.FillColor = color;
        win.Draw(sfmlText);
        Textlist.Add(sfmlText);
    }
}