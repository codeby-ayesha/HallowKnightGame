using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFrameWork
{
    public interface IAnimation
    {
        public string CurrentState { get; set; }
        public Dictionary<string, List<Image>> Animations { get; }
    }
}
