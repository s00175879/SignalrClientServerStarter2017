using Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameData;

namespace MonoGameClient
{
    class Collectable : AnimatedSprite
    {
        public CollectableData collectableData;
        public Collectable(Game game, Texture2D texture, Vector2 userPosition, int framecount) : base(game, texture, userPosition, framecount)
        {

        }
        public Collectable(Game game, CollectableData cData, Texture2D texture, Vector2 userPosition, int framecount) : base(game, texture, userPosition, framecount)
        {
            collectableData = cData;
        }

        protected override void LoadContent()
        {
            if(collectableData != null)
            {
                // Load Sprites associated with collectable type delivered
            }
            base.LoadContent();
        }

        public override void Update(GameTime gametime)
        {
            // Pull back player
            // delete collectable and sent captured message with collectable Data 
            // in it to server.
            base.Update(gametime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
