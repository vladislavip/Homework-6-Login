using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_Login
{
    internal class Class1
    {

        private string username;    //or string username
        private string password;
        
        public string Username

        {
            get { return username; }      // read

            set { if(value.Length < 5)
                {
                    throw new Exception("5 letters minimum");  // write
                } 
 
                username = value; 
            
            }   


        }
        public string Password

        {
            get { return password; }
            set
            {
                if (value.Length < 8)
                {

                    throw new Exception("8 symbols minimu");

                }

                password = value;
            }
        }


        public   bool CheckLoginAndPassword()

        {
            
            if (username=="Vlad123" && password=="12345678")

            {
                Console.WriteLine($"Welcome {username} ");
                return true;
            }
           else
            {

                Console.WriteLine("Wrong credentials");
                return false;   
            }
        }
        
     }

    
}
