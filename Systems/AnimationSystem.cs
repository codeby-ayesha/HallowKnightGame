using GameFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork
{
    public class AnimationSystem
    {
        public string CurrentState { get; set; }

        public void Update(IAnimation obj)
        {
            // 1️⃣ Current state check karo
            string state = obj.CurrentState;

            // 2️⃣ Dictionary se us state ki list uthao
            List<Image> frames = obj.Animations[state];

            // 3️⃣ FrameIndex ko update karo (ek frame aage)
            obj.CurrentFrame++;
            if (obj.CurrentFrame >= frames.Count)
            {
                obj.CurrentFrame = 0; // loop back
            }

            // 4️⃣ Current frame ko sprite pe set karo
            obj.Sprite = frames[obj.CurrentFrame];
        }
    }
}
