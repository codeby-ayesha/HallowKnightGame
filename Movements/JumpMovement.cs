using EZInput;
using GameFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork
{
    public class JumpMovement : IMovement 
    {

        private PointF jumpVelocity = new PointF (6f, 15f);  
        private bool isJumping = false;

        public void Move(GameObject obj, GameTime gameTime)
        {
            if (Keyboard.IsKeyPressed(Key.Space) && !isJumping)
            {
                obj.Position = new PointF(obj.Position.X, obj.Position.Y - 70);
                obj.Velocity = jumpVelocity;
                isJumping = true;
            }
        }

        public void Land()
        {
            isJumping = false;
        }
    }
}
