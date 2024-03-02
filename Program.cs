using System;
using cipher;

class Program {
    static public void Main(String[] args){
        Console.WriteLine("Hello, do you want to encrypt[0] or decrypt[1]?");
        Console.Write("Choice: ");
        int option = Convert.ToInt32(Console.ReadLine());

         switch (option){
            case 0:
                normalToVig.encryptMsg();
                break;   

            default:
                Console.WriteLine("Under development");
                break;   
         }
    }
}

