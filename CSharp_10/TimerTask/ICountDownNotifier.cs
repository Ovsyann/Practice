using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    interface ICountDownNotifier
    {
        void Init();

        void Run();

        void Unsubscribe();
    }
}
