using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace TicTacTwo {
    public class Cursor {
        int posX;
        int posY;
        Texture2D cursorImg;
        public Cursor() {
            cursorImg = Assets.Cursor;
            posX= 0; 
            posY = 0;
        }
    }
}
