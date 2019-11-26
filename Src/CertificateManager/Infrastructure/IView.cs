namespace CertificateManager.Infrastructure
{
    public interface IView
    {
        IPresenter Presenter { get; }
    }
}