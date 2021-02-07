namespace MySolution.BusinessClasses
{
    public interface IMessage
    {
        string Receiver { get; set; }
        string Content { get; set; }
        void Send();
    }
}
