
using ISP_Interface_Segregation_Principle;

Console.WriteLine("ISP - Interface Segregation Principle");

Human human = new();
Robot robot = new();

human.Work();
human.Eat();
robot.Work();
//robot.Eat(); // Acesso impossível, pois o robô não come
