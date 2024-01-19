using System;

namespace PrimeiroProjeto.Services
{
  class PrintService<T>
  {
    private T[] = _values = new T[10];
    private int _count = 0;

    public void AddValue(T value)
    {
      if (_count == 10)
      {
        throw new InvalidOperationException("This list is full")
      }
      _values[_count] = value;
      _count++;
    }

    public T First()
    {
      return _values[0];
    }

    public void Print()
    {
      Console.Write("[");
      for (int i = 0; i < _count - 1; i++)
      {
        Console.WriteLine(_values[i] + ", ");
      }
      if (_count > 0)
      {
        Console.WriteLine(_values[_count - 1]);
      }
      Console.WriteLine("]");
    }
  }
}