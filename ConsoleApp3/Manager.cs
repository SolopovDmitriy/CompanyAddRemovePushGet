using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Employee, IManager
    {
        private int lastIndex;
        private int workersCount;
        private IWorker[] _workers; //список рабочих текущего экземпляра менеджера
        public IWorker[] Workers { //поле получения доступа к рабочим текущего менеджера
            get
            {
                return _workers;
            }
        }
        public void addWorker(IWorker worker)
        {
            if(lastIndex < workersCount - 1)
            {
                lastIndex++;
                _workers[lastIndex] = worker;
            }
            else
            {
                Console.WriteLine("Свободных мест нет");
            }
           
        }
        public void removeWorker(IWorker worker)
        {
            bool isFound = false;
            int i;
            for (i = 0; i <= lastIndex; i++)
            {
                if(_workers[i] == worker)
                {
                    isFound = true;
                    break;
                }
            }                
            for (; i < lastIndex; i++)
            {
                _workers[i] = _workers[i + 1];
            }
            if (isFound)
            {
                lastIndex--;
            }           
        }

        public IWorker GetWorker(int index)
        {
            if (lastIndex >= index)
            {
                return _workers[index];
            }
            else
            {                
                return null;
            }        
        }

        public IWorker GetWorker(string workDescription)
        {           
            for (int i = 0; i <= lastIndex; i++)
            {
                if (_workers[i].Work() == workDescription)
                {                  
                    return _workers[i];
                }
            }
            return null;
        }

        public void PushWork(string task, IWorker[] workers)
        {
            for (int i = 0; i <= lastIndex; i++)
            {
                if (_workers[i].IsWorking == false)
                {
                    _workers[i].NextTask(task);
                    return;
                }
            }
        }

        public void PrintAllWorkers()
        {
            for (int i = 0; i <= lastIndex; i++)
            {
                Console.WriteLine(_workers[i]);
            }
        }

        public Manager()
        {
            lastIndex = -1;
            workersCount = 100;
            _workers = new IWorker[workersCount];
        }
















        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}
