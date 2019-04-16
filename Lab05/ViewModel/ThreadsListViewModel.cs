using Lab05.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.ViewModel
{

    internal class ThreadsListViewModel
    {
        public ProcessThreadCollection ProcessThreads { get; private set; }

        public ThreadsListViewModel(MyProcess process)
        {
            ProcessThreads = process.Process.Threads;
        }
    }

}
