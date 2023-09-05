using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGenerics.Events;

namespace ProjectGenerics.Notifications
{
    internal interface IPrint
    {
        /// <summary>
        /// интерфейс для метода вывода уведомления
        /// </summary>
        
        void Print();
    }
}
