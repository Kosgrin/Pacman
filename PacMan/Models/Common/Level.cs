using PacMan.Common;
using PacMan.Models.Abstract;
using PacMan.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PacMan.Models.Common
{
   public class Level :GameObject, IFormatable
    {

        private const string LevelText = "Level ";

        public Level() : base (new Position(420,20), new Size(0,30))
        {

            this.Text = LevelText;
            this.Value = 1;
        }

        //protected Level(Position position) : base(position, new Size(0, 25))
        //{
        //}

        public int Value { get; set; }

        protected string Text { get; set; }

        public TextBlock Format()
        {
            var textBlock = new TextBlock();
            textBlock.Text = this.Text + this.Value.ToString();
            textBlock.Foreground = new SolidColorBrush(Colors.Gold);
            textBlock.FontSize = 20;
            textBlock.FontWeight = FontWeights.Bold;
            return textBlock;
        }
    }

}

