using LSP_Liskov_Substitution_Principle;

Console.WriteLine("LSP - Liskov Substituition Principle.");

FlyingBird arara = new();
Penguin penguin = new();

Console.WriteLine($"Esta ave se move: {arara.Move()}");
Console.WriteLine($"Esta ave se move: {penguin.Move()}");
