namespace DotNet7Preview3Blazor.Client;

public class CounterState
{
    public int CurrentCount { get; private set; } = 0;

    public void IncrementCount() => CurrentCount++;
}
