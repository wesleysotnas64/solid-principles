
namespace DIP_Dependecy_Inversion_Principle
{
    public class Switch
    {
        public ISwitchable? Device { get; private set; }

        public Switch(ISwitchable _device) => SetDevice(_device);

        public void SetDevice(ISwitchable _device)
        {
            Device = _device;
        }

        public void Operate(bool _on)
        {
            if (Device != null)
            {
                if (_on) Device.TurnOn();
                else Device.TurnOff();
            }
        }

    }
}
