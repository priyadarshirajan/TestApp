using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp1.Service
{
    public class SingeltonService
    {
        private static SingeltonService _instance;

        private static readonly object _lock = new object();

        private SingeltonService()
        {

        }

        public static SingeltonService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingeltonService();
                    }

                    return _instance;
                }
            }
        }
}
