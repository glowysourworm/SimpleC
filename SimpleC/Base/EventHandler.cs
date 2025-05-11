namespace SimpleC.Base
{
    public delegate void SimpleHandler<T>(T obj);
    public delegate void SimpleHandler<T1, T2>(T1 obj, T2 arg1);
    public delegate void SimpleHandler<T1, T2, T3>(T1 obj, T2 arg2, T3 arg3);
}
