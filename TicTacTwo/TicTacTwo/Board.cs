using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace TicTacTwo {
    class Board {
        PlayerFraction[,] GameState;
        Texture2D graphic;

        public Board() {
            GameState = new PlayerFraction[3, 3];
            graphic = Assets.BoardBackground;
        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch) {
            spriteBatch.Draw(graphic, new Rectangle(0, 0, 300, 300), Color.White);
        }

    }
}
