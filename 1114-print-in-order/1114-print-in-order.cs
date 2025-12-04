using System;
using System.Threading;

public class Foo
{
    private AutoResetEvent secondDone = new AutoResetEvent(false);
    private AutoResetEvent thirdDone = new AutoResetEvent(false);

    public Foo()
    {
    }

    public void First(Action printFirst)
    {
        printFirst();
        secondDone.Set();   // allow second() to run
    }

    public void Second(Action printSecond)
    {
        secondDone.WaitOne(); // wait until first() completes
        printSecond();
        thirdDone.Set();     // allow third() to run
    }

    public void Third(Action printThird)
    {
        thirdDone.WaitOne(); // wait until second() completes
        printThird();
    }
}