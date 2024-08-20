
namespace DIP_Dependecy_Inversion_Principle
{
    public class Fireplace : SwitchableDevice
    {
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("The Fireplace is on!");
        }
        public override void TurnOff()
        {
            IsOn = true;
            Console.WriteLine("The Fireplace is off!");
        }
    }
}
