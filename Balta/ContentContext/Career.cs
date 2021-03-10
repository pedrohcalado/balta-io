using System.Collections.Generic;
using System.Linq;

namespace Balta.ContentContext
{
  public class Career : Content
  {
    public Career(string title, string url)
      : base(title, url)
    {
      Items = new List<CareerItem>();
    }
    public IList<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count(); // expression body, quando só tem um retorno no get

  }


}