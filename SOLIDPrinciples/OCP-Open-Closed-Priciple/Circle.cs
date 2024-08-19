
namespace OCP_Open_Closed_Priciple
{
    public class Circle : Shape
    {
        public float Radius { get; set; }
        public override float CalculateArea()
        {
            return (float) (Math.PI * Math.Pow(Radius, 2));
        }
    }
}
