namespace Prototype_pattern
{
    public interface  IMyCloneable <out T>
    {
        T MyClone();
    }
}