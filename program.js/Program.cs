

#region 2-nin quvvetidir mi
//Console.WriteLine("Bir eded daxil edin");

//string numStr = Console.ReadLine();

//int num = Convert.ToInt32(numStr);

//while (num % 2 == 0)
//{
//    num /= 2;
//}
//if (num == 1)
//{
//    Console.WriteLine("Eded 2-nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("Eded 2-nin quvveti deyil");
//}

#endregion

#region 2 eded araligi
//int num = 20;
//int num1 = 2;
//for (int i = num1 + 1; i < num; i++)
//{
//	Console.WriteLine(i);
//}

#endregion

#region 70-le ferqin olculmesi
//int num = 150;

//if (num > 70)
//{
//    Console.WriteLine((num - 70) * 3);
//}
//else
//{
//    Console.WriteLine(70 - num);
//} 
#endregion

#region X,Y,Z muqayisesi
//int X = 52368;
//int Y = 832;
//int Z = 3632;
//if (X > Y)
//{
//	if (X > Z)
//	{
//		Console.WriteLine(X);
//	}
//}
//else
//{
//	if (Y > Z)
//	{
//		Console.WriteLine(Y);
//	}
//	else
//	{
//		Console.WriteLine(Z);
//	}
//}
#endregion

#region n ve m araligi
int n = 5;
int m = 9;
int count = 1;

for (int i = n; i < m; i++)
{
	if (i % 2 == 0)
	{
		count++;
	}
}
Console.WriteLine(count); 
#endregion