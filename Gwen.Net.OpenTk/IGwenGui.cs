using System;
using Gwen.Net.Control;
using Gwen.Net.Skin;
using OpenTK.Mathematics;

namespace Gwen.Net.OpenTk
{
    public interface IGwenGui : IDisposable
    {
        ControlBase Root { get; }

        void Load(TexturedBase UniqueTexture = null);

        void Resize(Vector2i newSize);

        void Render();
    }
}
