namespace csharp_biblioteca
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Register register = new Register();
            register.SetGuest("Prencipe", "Davide", "blabla@gmail.com", "fhiidhhi", 3375551111);


           Documenti documenti = new Documenti();
            documenti.CreateCode();
            
            Documenti documenti2 = new Documenti();
            documenti2.CreateCode();
            
        }
    }
}
