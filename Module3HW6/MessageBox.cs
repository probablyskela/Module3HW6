namespace Module3HW6;

public static class MessageBox
{
    public delegate void WindowCloseHandler(State state);

    public static event WindowCloseHandler? WindowClose;

    public static async void Open()
    {
        Console.WriteLine("Window was opened.");
        await Task.Delay(3000);
        Console.WriteLine("Window was closed by the user.");
        var rand = new Random();
        WindowClose?.Invoke(rand.Next() % 2 == 0 ? State.Ok : State.Cancel);
    }
}