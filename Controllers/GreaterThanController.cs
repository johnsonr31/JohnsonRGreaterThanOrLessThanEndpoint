// Richard Johnson
// 10-25-22
// This API will take the user's input through the URL and print a message saying whether or not the numbers the user entered are greater than, less than, or equal to each other
// Peer Review by Carlos Felipe: This program works well. It correctly tells me which number is greater than, less than, or equal to which. The comments in the controller code are well written and tell me precisely what is going on. Overall great job. 

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRGreaterThanOrLessThan.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanController : ControllerBase
{
    [HttpGet]
    [Route("Greater/{number1}/{number2}")]

    public string GreaterThanOrLessThan(string number1, string number2)
    {
        // This is where we will declare our variables
        int num1 = 0;
        int num2 = 0;
        string result;
        
        // The two TryParse functions below will convert the inputs in the URL to ints
        Int32.TryParse(number1, out num1);
        Int32.TryParse(number2, out num2);
            // This if statement will check to see if num1 is greater than num2
            if (num1 > num2)
            {
                // If it is, the text below will be saved as a string called "result"
                result = $"{num1} is greater than {num2}.";
            }
            // If num1 isn't greater than num2, this else if statement will check to see if num1 is less than num2
            else if (num1 < num2)
            {
                // If it is, the text below will be saved as a string called "result"
                result = $"{num1} is less than {num2}.";
            }
            // If num1 isn't greater than or less than num2, then it must be equal to it, leading to this else statement
            else
            {
                // If this else statement is true, the text below will be saved as a string
                result = $"{num1} is equal to {num2}";
            }
        // After the numbers are checked, the result will be printed to the screen through the result string
        return result;
    }
}
