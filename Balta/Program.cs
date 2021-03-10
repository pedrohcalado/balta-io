﻿using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var articles = new List<Article>();
      articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre C#", "orientacao-objetos"));
      articles.Add(new Article("Artigo sobre .NET", "orientacao-objetos"));

      // foreach (var article in articles)
      // {
      //   Console.WriteLine(article.Id);
      //   Console.WriteLine(article.Title);
      //   Console.WriteLine(article.Url);
      // }
      var courses = new List<Course>();
      var courseOOP = new Course("OOP", "fundamentos-oop");
      var courseCsharp = new Course("C#", "fundamentos-c#");
      var courseAspNet = new Course("OOP", "fundamentos-aspnet");
      courses.Add(courseOOP);
      courses.Add(courseCsharp);
      courses.Add(courseAspNet);


      var careers = new List<Career>();
      var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
      var careerItem3 = new CareerItem(3, "OOP", "", courseOOP);
      var careerItem1 = new CareerItem(1, "Comece por aqui", "", null);
      var careerItem2 = new CareerItem(2, ".NET", "", courseAspNet);

      careerDotNet.Items.Add(careerItem2);
      careerDotNet.Items.Add(careerItem3);
      careerDotNet.Items.Add(careerItem1);
      careers.Add(careerDotNet);
      foreach (var career in careers)
      {

        foreach (var item in career.Items.OrderBy(x => x.Ordem))
        {
          Console.WriteLine($"{item.Ordem} - {item.Title}");
          Console.WriteLine(item.Course?.Title);
          Console.WriteLine(item.Course?.Level);

          foreach (var notification in item.Notifications)
          {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
          }
        }
      }

      var payPalSubscription = new PayPalSubscription();
      var student = new Student();
      student.CreateSubscription(payPalSubscription);
    }
  }
}
