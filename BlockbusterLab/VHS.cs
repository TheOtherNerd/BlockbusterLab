using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    public class VHS : Movie
    {
        public VHS(string Title, int RunTime, Genre Category, params string[] Scenes) : base(Title, RunTime, Category, Scenes)
        {

        }

        public override void Play()
        {
            
        }
    }
}
