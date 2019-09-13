using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.SoundProvider.SoundPlayers
{
    using PacMan.Logic;

    public class Menu : SoundPlayer
    {
        public Menu() : base(GlobalConstants.MenuSoundPath, false)
        {
        }
    }
}
