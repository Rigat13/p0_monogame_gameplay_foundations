
// Define a class that raises events
public class Player
{
    public event EventHandler<PlayerJumpedEventArgs> PlayerJumped;

    public void Jump(float jumpHeight)
    {
        OnPlayerJumped(new PlayerJumpedEventArgs { JumpHeight = jumpHeight });
    }

    protected virtual void OnPlayerJumped(PlayerJumpedEventArgs e)
    {
        PlayerJumped?.Invoke(this, e);
    }
}
