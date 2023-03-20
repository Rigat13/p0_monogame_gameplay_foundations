public class EventManager
{
    private Dictionary<string, EventHandler> eventHandlers;

    public EventManager()
    {
        eventHandlers = new Dictionary<string, EventHandler>();
    }

    public void AddHandler(string eventName, EventHandler handler)
    {
        if (!eventHandlers.ContainsKey(eventName))
        {
            eventHandlers.Add(eventName, handler);
        }
        else
        {
            eventHandlers[eventName] += handler;
        }
    }

    public void RemoveHandler(string eventName, EventHandler handler)
    {
        if (eventHandlers.ContainsKey(eventName))
        {
            eventHandlers[eventName] -= handler;
        }
    }

    public void TriggerEvent(string eventName, object sender, EventArgs args)
    {
        if (eventHandlers.ContainsKey(eventName))
        {
            eventHandlers[eventName]?.Invoke(sender, args);
        }
    }

    internal void AddHandler(string v, Action<object, PlayerJumpedEventArgs> handlePlayerJumped)
    {
        throw new NotImplementedException();
    }

    internal void RemoveHandler(string v, Action<object, PlayerJumpedEventArgs> handlePlayerJumped)
    {
        throw new NotImplementedException();
    }
}


