namespace FedoraDev.NodeEditor
{
    public interface IFactory
    {
        IConnection ProduceConnection();
    }
}
