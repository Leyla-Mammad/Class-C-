using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class user
    { public user ( string name, string surname, string password, byte num )
        {
            Name = name;
            Surname = surname;
            Password = password;
            Num = num;
        }
        public string Name {  get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public byte Num {  get; set; }


        public bool IsPasswordValid(string Password)
        {if( Password.Length < 6 || Password.Contains(Name) || !Password.Any(char.IsDigit) ){
                return false;
            }
            {
                return true;
            }

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Password: {Password}, Number: {Num}");
        }

    }
    
}
