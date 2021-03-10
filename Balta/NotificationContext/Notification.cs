namespace Balta.NotificationContext
{
  public sealed class Notification // classe não pode ser estendida por causa do sealed, pra manter o padrão
  {
    public Notification()
    {
      // vazio para caso alguém queira instanciar um construtor sem nada
    }

    public Notification(string property, string message)
    {
      Property = property;
      Message = message;
    }

    public string Property { get; set; }
    public string Message { get; set; }
  }
}