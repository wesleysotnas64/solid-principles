
namespace OCP_Open_Closed_Priciple
{
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public override float CalculateArea()
        {
            return Width * Height;
        }
    }
}
