﻿namespace LevelEditor.Models.UI
{
    using LevelEditor.Interfaces;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Text : GameObject, IDrawableGameObject
    {
        public string TextContent { get; set; }

        public SpriteFont SpriteFont { get; set; }

        public Color FontColor { get; set; }

        public Text(
            string textContent,
            SpriteFont spriteFont,
            Transform2D parentTransform = null)
            : this(textContent, spriteFont, new Transform2D(), parentTransform)
        {
        }

        public Text(
            string textContent,
            SpriteFont spriteFont,
            Transform2D transform,
            Transform2D parentTransform = null)
            : this(textContent, spriteFont, Color.Black, transform, parentTransform)
        {
        }

        public Text(
            string textContent,
            SpriteFont spriteFont,
            Color fontColor,
            Transform2D transform,
            Transform2D parentTransform = null)
        {
            this.TextContent = textContent;
            this.SpriteFont = spriteFont;
            this.FontColor = fontColor;

            this.Transform = transform;
            this.Transform.Parent = parentTransform;
        }

        public override void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Matrix viewMatrix)
        {
            spriteBatch.Begin(transformMatrix: viewMatrix);
            spriteBatch.DrawString(this.SpriteFont, this.TextContent, this.Transform.Position, this.FontColor);
            spriteBatch.End();
        }
    }
}
