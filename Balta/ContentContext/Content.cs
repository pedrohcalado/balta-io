using System;
using Balta.SharedContext;

namespace Balta.ContentContext
{
  // classe marcada como abstract pra impedir que seja instaciada, uma vez que não faz sentido instanciar uma classe de content
  public abstract class Content : Base
  {
    public Content(string title, string url)
    {
      // esse Id é gerado automaticamente em todas as classe filhas, SPOF (single point of failure)
      Title = title;
      Url = url;
    }
    public string Title { get; set; }
    public string Url { get; set; }
  }
}