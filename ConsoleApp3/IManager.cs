using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IManager
    {
        void addWorker(IWorker worker);
        void removeWorker(IWorker worker);
        IWorker GetWorker(int index);
        IWorker GetWorker(string workDescription);
        void PushWork(string task, IWorker[] workers);

    }
}
