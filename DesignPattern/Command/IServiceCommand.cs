namespace Command
{
    public interface IServiceCommand<T>
    {
        void Execute(T command);
    }
}
