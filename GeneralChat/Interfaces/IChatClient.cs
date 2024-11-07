namespace GeneralChat.Interfaces
{
    public interface IChatClient
    {
        Task ReceiveMessageAsync(string user, string message);
    }
}
