using System;
using SFML.Graphics;
using SFML.Window;

namespace topDown;

public class Background
{
    static RenderWindow fullscreenWindow { get; set; }
    public Background()
    {
        VideoMode videoMode = new VideoMode(1920, 1080); // Adjust the resolution as needed
        fullscreenWindow = new RenderWindow(videoMode, "Fullscreen Window", Styles.Fullscreen);
        fullscreenWindow.SetFramerateLimit(10);
    }
    
    public void fullScreen()
    {
        // Create the fullscreen window
        
       
        fullscreenWindow.DispatchEvents();
        fullscreenWindow.Clear(Color.Blue);
        fullscreenWindow.Display();
        
    }
}