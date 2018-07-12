﻿namespace C7Nutshell
{
    internal class Rectangle
    {
        public readonly float Width, Height;
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    }
}