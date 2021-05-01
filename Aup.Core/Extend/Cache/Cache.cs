using System;
using System.Collections.Generic;
using System.Text;

namespace Aup.Core.Extend.Cache
{
    public class Cache : ICache
    {
        public void SetCache()
        {
            Console.WriteLine("Cached");
        }
    }
}
