# Princípios SOLID
SOLID são cinco princípios da programação orientada a objetos que facilitam no desenvolvimento de softwares, tornando-os fáceis de manter e estender. Esses princípios podem ser aplicados a qualquer linguagem de POO.

## S.O.L.I.D. é um acronomo para:
- **S:** Single Responsiblity Principle (Princípio da responsabilidade única)
- **O:** Open-Closed Principle (Princípio Aberto-Fechado)
- **L:** Liskov Substitution Principle (Princípio da substituição de Liskov)
- **I:** Interface Segregation Principle (Princípio da Segregação da Interface)
- **D:** Dependency Inversion Principle (Princípio da inversão da dependência)

## Single Responsiblity Principle (SRP)
Princípio da responsabilidade única.

_“Uma classe deve ter um, e somente um, motivo para mudar.”_

### Exemplo:
Uma classe Employee (Funcionário) que gerencia tanto informações do funcionário quanto operações de impressão.

```csharp
public class Employee
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public float Salary { get; set; }

  // Método para aumentar o salário
  public void IncreaseSalary(double percentage)
  {
    Salary += Salary * percentage / 100;
  }

  // Método para imprimir os detalhes do funcionário
  public void PrintDetails()
  {
    Console.WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary}");
  }
}
```

### Problema
A classe Employee tem mais de uma responsabilidade: gerenciar dados do
funcionário e lidar com a impressão do dados.

### Solução
Separar os interesses. Cada classe deve ficar responsável por uma função específica.

```csharp
public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public float Salary { get; set; }
}

public class EmployeeSalaryManager
{
    public static void IncreaseSalary(Employee employee, float percentage)
    {
        employee.Salary *= percentage;
    }
}

public class EmployeePrinter
{
    public static void PrintAllAttributes(Employee employee)
    {
        Console.WriteLine($"Id: {employee.Id} | Name: {employee.Name} | Salary: {employee.Salary}");
    }
}
```
Utilização:
```csharp
Employee emplyee01 = new()
{
    Id = 1,
    Name = "Bob Dylan",
    Salary = 2480.0f
};

EmployeePrinter.PrintAllAttributes(emplyee01);
EmployeeSalaryManager.IncreaseSalary(emplyee01, 1.1f);
EmployeePrinter.PrintAllAttributes(emplyee01);
```

### Benefício
Dessa forma o código fica separado garantindo uma melhor leitura e manutenção.

## Open/Closed Principle (OCP)
Princípio Aberto-Fechado

_“Objetos ou entidades devem estar abertos para extensão, mas fechados para
modificação.”_
### Exemplo
Uma classe AreaCalculator que calcula a área de diferentes formas
geométricas.
```csharp
public class AreaCalculator
{
  public float CalculateRectangleArea(float width, float height)
  {
    return width * height;
  }

  public float CalculateCircleArea(float radius)
  {
    return (float) (Math.PI * Math.Pow(radius, 2));
  }
}
```
### Problema
Cada vez que uma nova forma geométrica é adicionada, a classe AreaCalculator precisa ser modificada.
### Solução
Reestruturar o código utilizando os conceitos de abstração, herança e polimorfismo.

```csharp
public abstract class Shape
{
    public abstract float CalculateArea();
}

public static class AreaCalculator
{
    public static float CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}

public class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }
    public override float CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public float Radius { get; set; }
    public override float CalculateArea()
    {
        return (float) (Math.PI * Math.Pow(Radius, 2));
    }
}
```
Utilização
```csharp
Circle circle = new()
{
    Radius = 10
};

Rectangle rectangle = new()
{
    Width = 4,
    Height = 10
};

Console.WriteLine($"Circle Area: {AreaCalculator.CalculateArea(circle)}");
Console.WriteLine($"Rectangle Area: {AreaCalculator.CalculateArea(rectangle)}");
```
### Benefício
Novas formas geométricas podem ser adicionadas estendendo a classe Shape sem modificar a classe AreaCalculator.

## Liskov Substitution Principle (LSP)
Princípio da substituição de Liskov

_“Uma classe derivada deve ser substituível por sua classe base.”_
### Exemplo
Uma classe Bird e uma classe derivada Penguin. Ambos são aves, porém pinguim não voa.
```csharp
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguins can't fly");
    }
}
```
### Problema
A classe Penguin não pode substituir Bird corretamente, pois lança uma exceção quando o método Fly é chamado.
### Solução
Utilizar polimorfismo, pois cada um deles se movimenta, mas de maneira diferente.
```csharp
public abstract class Bird
{
    public abstract string Move();
}

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

public class Penguin : Bird
{
    public override string Move()
    {
        return Walk();
    }

    private static string Walk()
    {
        return "Caminhando";
    }
}
```
Utilização
```csharp
FlyingBird arara = new();
Penguin penguin = new();

Console.WriteLine($"Esta ave se move: {arara.Move()}");
Console.WriteLine($"Esta ave se move: {penguin.Move()}");
```
### Benefício
Penguin pode substituir Bird corretamente, respeitando o comportamento esperado de movimentação.
