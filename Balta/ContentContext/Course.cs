using System.Collections.Generic;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
  public class Course : Content
  {
    public Course(string title, string url)
      : base(title, url)
    {
      Modules = new List<Module>(); // sempre que trabalharmos com um objeto dentro de outro, seja ele uma lista (caso do Modules) ou um objeto só, é recomendado inicializar-lo dentro do construtor pra que não dê erro no caso de dar um foreach, por exemplo
    }
    public string Tag { get; set; }
    public IList<Module> Modules { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }

  }

}