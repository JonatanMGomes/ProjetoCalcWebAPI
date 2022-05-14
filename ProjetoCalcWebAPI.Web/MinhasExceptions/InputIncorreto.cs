namespace ProjetoCalcWebAPI.Web.MinhasExceptions
{
    public class InputIncorreto : Exception
    {
        public InputIncorreto (){

        }
        public InputIncorreto(string msg) : base(msg)
        {
            
        }
    }
}