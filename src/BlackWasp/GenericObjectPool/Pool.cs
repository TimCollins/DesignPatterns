using System.Collections.Generic;

namespace BlackWasp.GenericObjectPool
{
    /// <summary>
    /// See http://www.blackwasp.co.uk/GenericObjectPool.aspx
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Pool<T> where T : new()
    {
        private List<T> _available = new List<T>(); 
        private List<T> _inUse = new List<T>(); 


    }
}
