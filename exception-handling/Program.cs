try
{
    Console.WriteLine("Enter a number:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Entered num of: " + num);
}
catch (Exception ex)
{
    Console.WriteLine("Error" + ex.Message.ToString());
}
//finally
//{
//    Console.Write("Proccess Completed.");
//}

try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Enter empty value:");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Value type is not suitable");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("You entered a value that is too small or too large.");
    Console.WriteLine(ex);
}
finally
{
    Console.Write("Proccess Completed.");
}