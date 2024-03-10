//exceptions -istisna demekdir,mueyyen sehvler
//exceptions-bir classdir,2 yere bolunur-system ve application

using Exceptions.Controllers;
using Exceptions.Helpers.Exceptions;
using Exceptions.Models;
using System.Data;
using System.Diagnostics.SymbolStore;

//void Calculate()
//{

//    bool isCorrectCode = true;

//	try
//        //kodu burda yaz
//	{

//        int a = 5;
//        int b = 0;
//        //var result = a / b;
//        //Console.WriteLine(result);
//        //if(b== 0)
//        //{
//        //    Console.WriteLine("dont divide to zero");
//        //    return;
//        //}

//        int[] arr = { 1, 2, 3 };

//       // arr[5] = 100;
//    }
//	//catch (DivideByZeroException ex)//exception bura kecir
//	//{

// //       Console.WriteLine(ex.Message);
// //   }
// //   catch (IndexOutOfRangeException ex)
// //   {
// //       Console.WriteLine(ex.Message);
// //   }
// //   catch(Exception ex)
// //   {
// //       Console.WriteLine(ex.Message);
// //   }
// catch(Exception ex)
//    {
//        isCorrectCode = false;
//    }
//    finally
//    {
//        SentMessage(isCorrectCode);
//    }




//}
////Calculate();
//void SentMessage(bool isCorrectCode)
//{
//    if (isCorrectCode)
//    {
//        Console.WriteLine("Your message  successfully");
//    }
//    else { Console.WriteLine("your message failed"); }
//}
//  string GetById(int? id)
//{
//    try
//    {
//        if(id == null)
//        {
//            // throw new ArgumentNullException(nameof(id),"Salam menem exception");
//            throw new CustomArgumentNullException("Argument cannot be null");

//        }
//        //ArgumentNullException.ThrowIfNull(id);
//        return "Kamran bey";
//    }
//    catch (Exception ex)
//    {

//        return ex.Message;
//    }
//    //if (id == null)
//    //{
//    //    throw new ArgumentNullException();
//    //}
//    //return "Kamran bey";
//}
//   var result =GetById(null);
//Console.WriteLine(result);


//Ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin.
//try
//{
//	int number = -5;
//	int factorial=FactorialCalculator.CalculateFactorial(number);
//    Console.WriteLine($"Factorial: {factorial}");

//}
//catch (NegativNumberException ex)
//{

//    Console.WriteLine($"Xeta : {ex.Message}");
//}

//Login ucun custom exception yazib isdifade etmek. Eger email ve yaxud password sehvdirse custom exception istifade edin. Models, Services, Controller folderleriniz olacaq.
//Service mentiqi ile yazirsiz.
//UserController userController = new UserController();
//userController.Handlelogin("test@example.com", "password123");
//userController.Handlelogin("invalid@example.com", "invalidpassword");

Login login=new Login();
try
{
	login.CheckPassword("12345");
}
catch (PasswordLengthException ex)
{

    Console.WriteLine(ex.Message);
}