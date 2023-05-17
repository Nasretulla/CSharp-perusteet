namespace Exercise001
{
    public class Program
    {
        public static void Main(string[] args)
        {

            GradeRegister register = new GradeRegister();
            UserInterface uusi = new UserInterface(register);

            uusi.Start();


        }
    }
}