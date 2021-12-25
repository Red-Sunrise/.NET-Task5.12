using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface ITechnic
    {
        string ModelName { get; set; }
        Dictionary<string, object> GetParameters();
        void ChangeState(State state);
    }
}
