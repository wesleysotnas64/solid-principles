
namespace DIP_Dependecy_Inversion_Principle
{
    public abstract class SwitchableDevice : ISwitchable
    {
        public bool IsOn { get; protected set; }

        protected SwitchableDevice() => IsOn = false;

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
