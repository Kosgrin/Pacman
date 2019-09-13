namespace PacMan
{
    using System.Windows;
    using PacMan.Logic;
    using PacMan.Maps;
    using PacMan.Renderers;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
         
       SoundProvider.SoundProvider sound = new SoundProvider.SoundProvider();
        public StartWindow()
        {
          

         sound.MenuSoundOn();
          
       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sound.MenuSoundOff();
            this.InitializeComponent();
            var renderer = new GameRenderer(this.GameCanvas);
            var map = new Classic();
            var engine = new Engine(map, renderer);
            engine.InitGame();
            engine.DrawGameObjects();
            
        }

       
    }
}
