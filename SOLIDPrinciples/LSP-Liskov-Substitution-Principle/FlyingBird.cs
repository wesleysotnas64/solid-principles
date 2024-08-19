
namespace LSP_Liskov_Substitution_Principle
{
    public class FlyingBird : Bird
    {
        public override string Move()
        {
            return Fly();
        }
        private static string Fly()
        {
            return "Batendo asas";
        }
    }
}
