namespace System.MVC
{
    public partial interface IView
    {
        void Render(object model);
        object Content { get; }
    }

    public interface IAsyncView
    {
    }
}
