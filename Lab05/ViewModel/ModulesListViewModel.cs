using Lab05.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.ViewModel
{
    internal class ModulesListViewModel
    {
        public ProcessModuleCollection ProcessModules { get; private set; }

        public ModulesListViewModel(MyProcess process)
        {
            ProcessModules = process.Process.Modules;
        }
    }
}
