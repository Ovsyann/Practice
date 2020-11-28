using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask
{
    class LambdaProcessor :ICountDownNotifier
    {
        public LambdaProcessor(Timer timer, TaskTimeStarted taskTimeStarted, Action<string, int> timeEnd)
        {

        }

        void ICountDownNotifier.Init()
        {
            throw new NotImplementedException();
        }

        void ICountDownNotifier.Run()
        {
            throw new NotImplementedException();
        }

        void ICountDownNotifier.Unsubscribe()
        {
            throw new NotImplementedException();
        }
    }
}
