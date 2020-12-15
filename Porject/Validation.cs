using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Project
{
    internal class CredentialCheck : AbstractValidation
    {

        public override void Checkusernameandpassword()
        {
            Console.WriteLine("Enter the username");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string Password = Console.ReadLine();
            if (Username != username || Password != password)
            {
                throw new Exception();
            }
        }
       
    }
    public sealed class Validation
    {
        private Validation()
        {
        }
        private static Validation instance = null;
        public static Validation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Validation();
                }
                return instance;
            }
        }
        public void Validate()
        {
            while (true)
            {
                try
                {
                    var credentialcheck = new CredentialCheck(); 
                    credentialcheck.Checkusernameandpassword();

                }

                catch (Exception )
                {
                    Console.WriteLine("\nInvalid Credentials ,try again \n");
                    continue;
                }
                break;
            }
        }
    }
}


