namespace NanoTweenRootNamespace.Pooling.Buffer
{
    internal abstract class AbstractPooledBuffer<T>
        where T : AbstractPooledBuffer<T>, new()
    {
        protected static T PoolRoot = new();
        
        protected T Next;
        
        public ushort Revision;
        
        public static T GetPooled()
        {
            if (PoolRoot == null) return new T();
            
            var result = PoolRoot;
            PoolRoot = PoolRoot.Next;
            result.Next = null;
            
            result.Reset();
            
            return result;
        }
        
        public static void Release(T buffer)
        {
            buffer.Revision++;
            buffer.Reset();
            
            if (buffer.Revision != ushort.MaxValue)
            {
                buffer.Next = PoolRoot;
                PoolRoot = buffer;
            }
        }
        
        protected abstract void Reset();
    }
}