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