using GameFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GameFrameWork
{
    public class BackgroundLayer : GameObject
    {
        public Image background;
        public PointF size;

        public BackgroundLayer(Image background, PointF size)
        {
            this.background = background;
            this.size = size;
        }

        public void Draw(Graphics g)
        {
            base.Draw(g);
        }
    }
}
