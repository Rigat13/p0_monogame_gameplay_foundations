
// Define an event handler
public class JumpHeightLogger
{
    public void HandlePlayerJumped(object sender, PlayerJumpedEventArgs e)
    {
        Console.WriteLine($"Player jumped {e.JumpHeight} units high");
    }
}
