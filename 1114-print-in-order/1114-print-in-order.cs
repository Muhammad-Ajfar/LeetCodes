using System;
using System.Threading;

public class Foo {
    private SemaphoreSlim second = new SemaphoreSlim(0,1);
    private SemaphoreSlim third = new SemaphoreSlim(0,1);

    public Foo() {}

    public void First(Action printFirst) {
        printFirst();
        second.Release();
    }

    public void Second(Action printSecond) {
        second.Wait();
        printSecond();
        third.Release();
    }

    public void Third(Action printThird) {
        third.Wait();
        printThird();
    }
}