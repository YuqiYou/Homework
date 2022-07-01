// See https://aka.ms/new-console-template for more information
using ColorProj;

Color color1 = new Color(10, 30, 50);
Color color2 = new Color(30, 60, 90);
Ball ball1 = new Ball(0, color1, 0);
Ball ball2 = new Ball(0, color2, 0);

int greyScale = color1.getGrayscale();
Console.WriteLine($"The color greyScale is {greyScale}");

Console.WriteLine("times before ball is thrown ");
Console.WriteLine(ball1.TimesThrown);

ball1.Throw();
Console.WriteLine("times After ball is thrown ");
Console.WriteLine(ball1.TimesThrown);

ball1.Throw();
Console.WriteLine("times After ball is thrown again ");
Console.WriteLine(ball1.TimesThrown);