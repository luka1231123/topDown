using System;
using SFML.Graphics;
using SFML.Window;
using SFML.Audio;


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
    
    public void FullScreen()
    {
        // Create the fullscreen window
        var music = new Music("C:\\Users\\lukar\\Source\\Repos\\topDown\\1.wav");
        music.Loop = true;
        music.Play();

        while (Program.running)
        {
            fullscreenWindow.DispatchEvents();
            fullscreenWindow.Clear(Color.Blue);
            fullscreenWindow.Display();
        }
        if (!Program.running)
        {
            music.Stop();
        }
        
    }
}