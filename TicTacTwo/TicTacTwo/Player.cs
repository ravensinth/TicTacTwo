using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacTwo {
    class Player {
        private PlayerFraction _fraction;
        public PlayerFraction Fraction {
            get { return _fraction; }
        }


        public Player(PlayerFraction fraction) {
            fraction = _fraction;
        }
    }
}
