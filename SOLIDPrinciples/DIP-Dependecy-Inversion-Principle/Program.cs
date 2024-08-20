
using DIP_Dependecy_Inversion_Principle;

Console.WriteLine("DIP - Dependency Inversion Principle");

ISwitchable ligth = new Light();
ISwitchable fireplace = new Fireplace();

Switch _switch = new(ligth);

_switch.Operate(true);
_switch.Operate(false);

_switch.SetDevice(fireplace);

_switch.Operate(true);
_switch.Operate(false);