
namespace ISP_Interface_Segregation_Principle
{
    public class Human : IWorkable, IFeedable
    {
        public void Work()
        {
            Console.WriteLine("Human working!");
        }

        public void Eat()
        {
            Console.WriteLine("Human eating!");
        }
    }
}
