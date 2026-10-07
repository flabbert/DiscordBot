namespace DiscordBot.SharedKernel;

public interface IIdentifiable<T>
{
    public T Id { get; set; }
}