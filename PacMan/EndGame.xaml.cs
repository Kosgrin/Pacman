using System;
using System.Windows;
using PacMan.Logic;
using PacMan.Maps;
using PacMan.Renderers;

namespace PacMan
{
    /// <summary>
    /// Interaction logic for EndGame.xaml
    /// </summary>
    public partial class EndGame : Window
    {
        public EndGame()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.InitializeComponent();
            var renderer = new GameRenderer(this.GameCanvas);
            var map = new Classic();
            var engine = new Engine(map, renderer);
            engine.InitGame();
            engine.DrawGameObjects();
        }

        

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            
        }
    }
}
