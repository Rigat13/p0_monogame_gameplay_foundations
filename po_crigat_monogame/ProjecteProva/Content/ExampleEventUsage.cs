// Create a basic class
public class ExampleEventUsage
{
    // Create a delegate
    public delegate void ExampleEventHandler(object sender, EventArgs e);
    // Create an event based on that delegate
    public event ExampleEventHandler ExampleEvent;
    // Create a method to raise the event
    protected virtual void OnExampleEvent(EventArgs e)
    {
        if (ExampleEvent != null)
            ExampleEvent(this, e);
    }
    // Call that method whenever you want to raise the event
    public void RaiseExampleEvent()
    {
        OnExampleEvent(EventArgs.Empty);
    }



    public static void Main(string[] args)
    {
        // Example usage
        EventManager eventManager = new EventManager();
        Player player = new Player();
        JumpHeightLogger logger = new JumpHeightLogger();

        // Register the event handler
        eventManager.AddHandler("PlayerJumped", logger.HandlePlayerJumped);

        // Trigger the event
        player.Jump(10.0f);
        eventManager.TriggerEvent("PlayerJumped", player, new PlayerJumpedEventArgs { JumpHeight = 10.0f });

        // Unregister the event handler
        eventManager.RemoveHandler("PlayerJumped", logger.HandlePlayerJumped);
    }
}