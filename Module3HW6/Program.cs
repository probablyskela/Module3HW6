using Module3HW6;

Task<State> WaitForWindowClose()
{
    var tcs = new TaskCompletionSource<State>();
    MessageBox.WindowClose += state => tcs.SetResult(state);
    return tcs.Task;
}

MessageBox.Open();

switch (await WaitForWindowClose())
{
    case State.Ok:
        Console.WriteLine("Operation was approved.");
        break;
    case State.Cancel:
        Console.WriteLine("Operation was declined.");
        break;
    default:
        throw new ArgumentOutOfRangeException();
}