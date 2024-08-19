
namespace LSP_Liskov_Substitution_Principle
{
    public class Penguin : Bird
    {
        public override string Move()
        {
            return Walk();
        }

        private static string Walk()
        {
            return "Caminhando";
        }
    }
}
