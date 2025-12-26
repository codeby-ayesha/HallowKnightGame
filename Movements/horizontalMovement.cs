using EZInput;
using GameFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallowKnight.Movements
{
    public class horizontalMovement : IMovement
    {
        int speed= 8;
        public float Leftbound =0;
        public float Rightbound= 2000;

        public void Move(GameObject obj, GameTime gameTime)
        {
            obj.Position = new PointF(obj.Position.X, obj.Position.Y);
            if (Keyboard.IsKeyPressed(Key.H) && (obj.Position.X>Leftbound))
            {
                obj.Position = new PointF(obj.Position.X-speed, obj.Position.Y);
            }
            if (Keyboard.IsKeyPressed(Key.H) && obj.Position.X <= Leftbound)
            {
                obj.Position = new PointF(obj.Position.X + speed, obj.Position.Y);
            }
        }
    }
}
