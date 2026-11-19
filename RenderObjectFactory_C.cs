using OpenTK;
using OpenTK.Graphics;
using techdump.opengl.Components.Renderables;

namespace techdump.opengl.Components
{
    public class RenderObjectFactory_C
    {
        public static ColoredVertex_C[] CreateSolidCube_C(float side, Color4 color)
        {
            side = side / 2f; // half side - and other half
            ColoredVertex_C[] vertices_C =
            {
                new ColoredVertex_C(new Vector4(-0.5f, 0.5f, -0.5f, 1.0f),   Color4.Red),
                new ColoredVertex_C(new Vector4(0.5f, -0.5f, 0.5f, 1.0f),    Color4.Red),
                new ColoredVertex_C(new Vector4(0.5f, 0.5f, -0.5f, 1.0f),    Color4.Red),

                new ColoredVertex_C(new Vector4(-0.5f, 0.5f, -0.5f, 1.0f),    Color4.Green),
                new ColoredVertex_C(new Vector4(-0.5f, -0.5f, 0.5f, 1.0f),    Color4.Green),
                new ColoredVertex_C(new Vector4(0.5f, 0.5f, -0.5f, 1.0f),     Color4.Green),


                new ColoredVertex_C(new Vector4(-0.5f, 0.5f, -0.5f, 1.0f),    Color4.Blue),
                new ColoredVertex_C(new Vector4(0.5f, 0.5f, -0.5f, 1.0f),     Color4.Blue),
                new ColoredVertex_C(new Vector4(0.5f, -0.5f, 0.5f, 1.0f),     Color4.Blue),
       

                // 6*6 = 36 vertices total, 12 triangles, 2 triangles per face  / 18 half
                
            };
            return vertices_C;
        }
    }
}