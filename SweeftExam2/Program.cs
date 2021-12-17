using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Xml;

namespace SweeftExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.     დაწერეთ ფუნქცია, რომელსაც გადაეცემა ტექსტი  და აბრუნებს პალინდრომია თუ არა.
            // (პალინდრომი არის ტექსტი რომელიც ერთნაირად იკითხება ორივე მხრიდან). 

            //Console.WriteLine("Enter a number: ");
            //string str = Console.ReadLine();
            //if (Palindrome.isPalindrome(str))
            //    Console.WriteLine("The number is Palindrome");
            //else
            //    Console.WriteLine("The number is not Palindrome");

            //------------------------------------------------------------------------------------------------------------------------------------

            //2.     გვაქვს 1,5,10,20 და 50 თეთრიანი მონეტები. დაწერეთ ფუნქცია, რომელსაც გადაეცემა თანხა (თეთრებში)
            //და აბრუნებს მონეტების მინიმალურ რაოდენობას, რომლითაც შეგვიძლია ეს თანხა დავახურდაოთ.

            //Console.WriteLine("Enter the total value: ");
            //int value = int.Parse(Console.ReadLine());
            //Console.Write("Minimum coins required is " + Coins.minSplit(value));

            //------------------------------------------------------------------------------------------------------------------------------------

            //3.     მოცემულია მასივი, რომელიც შედგება მთელი რიცხვებისგან.
            //დაწერეთ ფუნქცია რომელსაც გადაეცემა ეს მასივი და აბრუნებს მინიმალურ მთელ რიცხვს,
            //რომელიც 0-ზე მეტია და ამ მასივში არ შედის.

            //int[] ar = new int[] { 5, 2, 1, 3, -3, 14, 17 };
            //Console.WriteLine(NotContains.notContains(ar));

            //------------------------------------------------------------------------------------------------------------------------------------

            //4.     მოცემულია String რომელიც შედგება „(„ და „)“ ელემენტებისგან.
            //დაწერეთ ფუნქცია რომელიც აბრუნებს ფრჩხილები არის თუ არა მათემატიკურად სწორად დასმული.

            //Console.WriteLine("Enter parentheses");
            //string str = Console.ReadLine();
            //if (ParenthesesCheck.isProperly(str))
            //    Console.WriteLine("Parentheses are written properly");
            //else
            //    Console.WriteLine("Parentheses are written wrong");

            //------------------------------------------------------------------------------------------------------------------------------------

            //5.     გვაქვს n სართულიანი კიბე, ერთ მოქმედებაში შეგვიძლია ავიდეთ 1 ან 2 საფეხურით.
            //დაწერეთ ფუნქცია რომელიც დაითვლის n სართულზე ასვლის ვარიანტების რაოდენობას.

            //Console.WriteLine("Please enter the number of stairs");
            //int stairs = int.Parse(Console.ReadLine());

            //if (stairs < 0)
            //    Console.WriteLine("You can't go the negative number of stairs. Try positive number");
            //else
            //    Console.WriteLine($"The possible ways to climb {stairs} amount of stairs is: {Stairs.CountVariants(stairs)}");

            //------------------------------------------------------------------------------------------------------------------------------------

            //6.     დაწერეთ საკუთარი მონაცემთა სტრუქტურა, რომელიც საშუალებას მოგვცემს O(1) დროში წავშალოთ ელემენტი.

            //List<string> stringList = new List<string>() { "A", "B", "C", "D" };
            //var variable = new DataStruct<string>(stringList);
            //variable.Remove("A");
            //foreach (string item in variable.items)
            //{
            //    Console.WriteLine(item);
            //}

            //------------------------------------------------------------------------------------------------------------------------------------

            //7. SQL  დამატებულია

            //------------------------------------------------------------------------------------------------------------------------------------

            //8.     მოცემულია საქართველოს ეროვნული ბანკის RSS feed-ის მისამართი: http://www.nbg.ge/rss.php ,
            //რომელიც არბუნებს მიმდინარე ვალუტის კურსებს. დაწერეთ ფუნქცია, რომელსაც გადაეცემა ორი ვალუტის
            //იდენტიფიკატორი(USD, GEL, EUR…) და აბრუნებს ვალუტებს შორის გაცვლის კურსს.

            //string rssUrl = string.Concat("http://www.nbg.ge/rss.php");

            //XmlDocument doc = new XmlDocument();
            //doc.Load(rssUrl);

            //var description = doc.GetElementsByTagName("description");

            //Console.WriteLine(description[1].InnerText);

            //HtmlDocument htDoc = new HtmlDocument();


            //------------------------------------------------------------------------------------------------------------------------------------


        }
    }
}
