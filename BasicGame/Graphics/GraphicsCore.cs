using System.Collections.Generic;

namespace Game
{
    namespace Graphics
    {
        public interface ITilePosition
        {
            int X { get; }
            int Y { get; }
        }
        public interface IUnitPosition 
        {
            float X { get; }
            float Y { get; }
        }
        public interface IAdditionDrawer
        {
            void DrawAddition(System.Drawing.Graphics graphics,in ICamera camera);
        }
        public interface ILightDrawer
        {
            void DrawLight(System.Drawing.Graphics graphics, in ICamera camera);
        }
        public interface IInterfaceDrawer
        {
            void DrawInterface(System.Drawing.Graphics graphics, in ICamera camera);
        }
        public interface IDrawebleTile
        {
            string Path { get; }
        }
        public interface IDrawebleUnit
        {
            string Path { get; }
        }
        public interface ICamera : IUnitPosition
        {
            float Scale { get; }
        }
        public interface BasicTile : ITilePosition,IDrawebleTile 
        {
            
        }
        public class Drawer
        {

            public ICamera BindedCamera { get; set; }
            public List<BasicTile> tiles { get; protected set; } = new List<BasicTile>();

            protected int TileWidth = 32;
            protected System.Drawing.Graphics targetGraph;
            protected System.Drawing.Size ImageSize;

            public Drawer(System.Drawing.Graphics graphics,ICamera camera,System.Drawing.Size CanvasSize)
            {
                targetGraph = graphics;
                BindedCamera = camera;
                ImageSize = CanvasSize;
            }

            public void Draw()
            {
                System.Drawing.RectangleF bound = new System.Drawing.RectangleF(BindedCamer.X - ,BindedCamera.Y)
                foreach (BasicTile tile in tiles)
                {
                    
                }
            }
        }
    }
}