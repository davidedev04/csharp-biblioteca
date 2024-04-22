using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Register
    {

            private string Surname { get; set; }
            private string Name { get; set; }
            private string Email { get; set; }
            private string Password { get; set; }
            private double Phone { get; set; }

            public Register()
            {
                Surname = string.Empty;
                Name = string.Empty;
                Email = string.Empty;
                Password = string.Empty;
                Phone = 0;
            }

            public Register(string surname, string name, string email, string password, double phone) : this()
            {
                Surname = surname;
                Name = name;
                Email = email;
                Password = password;
                Phone = phone;
            }

            public void SetGuest(string surname, string name, string email, string password, double phone)
            {
            Console.WriteLine($"il tuo cognome é: {surname}");
            Console.WriteLine($"il tuo nome é: {name}");
            Console.WriteLine($"la tua mail é: {email}");
            Console.WriteLine($"la tua password é: {password}");
            Console.WriteLine($"il tuo recapito telefonico é: {phone}");
            }

            /*Console.WriteLine("--- REGISTRAZIONE ---");
            Console.WriteLine("Inserisci il tuo nome:");
            Console.ReadLine("");*/
        }
}
