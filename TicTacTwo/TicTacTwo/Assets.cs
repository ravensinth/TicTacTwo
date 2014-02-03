using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace TicTacTwo {
    public static class Assets {
        public static Texture2D BoardBackground { get; set; }
        public static Texture2D Circle { get; set; }
        public static Texture2D Cross { get; set; }
        public static Texture2D Cursor { get; set; }


        public static void LoadContent(ContentManager content) {
            BoardBackground = content.Load<Texture2D>("BoardBack");
            Circle = content.Load<Texture2D>("circle");
            Cross = content.Load<Texture2D>("cross");
            Cursor = content.Load<Texture2D>("glove");
        }
    }
}
