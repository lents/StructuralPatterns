﻿namespace Bridge
{
    public abstract class Shape
    {
        protected readonly IRenderer Renderer;

        protected Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public abstract void Draw();
    }

}
