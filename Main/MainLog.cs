using SFML.Graphics;

namespace topDown.Main;

public class MainLog
{
    private double c=0;
    private double v=0;
    private MainWindow win = new MainWindow(1024, -1, "MainWindow");
    static vec3[,] vec3array = new vec3[32,32];
    public void Refresh()
    {
        win.Refresh();
        
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
    }

    private List<Text> texts = new List<Text>();
    
    public void Draw()
    {
        win.Draw(texts);
    }
    // i have to think for a solution for this.

    public bool WindOpen()
    {
        return win.WindOpen();
    }
    
    
    public void paintTile(int tileX, int tileY, string path, vec3 color)
    {
        for(int i=0; i<18; i++){
            for(int j=0;j<18;j++){
                win.SetPixelArray((i+(tileX*18)+448), (j+(tileY*18)), color);
            }
        }
    }
    
}

//event handling