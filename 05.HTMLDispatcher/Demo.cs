﻿namespace _05.HTMLDispatcher
{
    using System;
    using Models;
    using Utils;

    public class Demo
    {
        public static void Main(string[] args)
        {
            var li = new ElementBuilder("li");
            li.AddAttribute("class", "coolClass");
            li.AddContent("test");
            var ul = new ElementBuilder("ul");
            ul.AddContent(li * 2);
            Console.WriteLine(ul);

            Console.WriteLine(HtmlDispatcher.CreateImage("http://abv.bg/logo.jpg", "Logo", "ABV"));
            Console.WriteLine(HtmlDispatcher.CreateUrl("http://abv.bg/", "Click me", "Abv site"));
            Console.WriteLine(HtmlDispatcher.CreateInput("button", "Submit", "Click"));
        }
    }
}