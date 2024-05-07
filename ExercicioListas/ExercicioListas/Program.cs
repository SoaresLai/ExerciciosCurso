using System;
using System.Globalization;
using ExercicioLista;

Console.Write("Quantos Funcionarios serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Employers> list = new List<Employers>();

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Funcionario #" + i + ":");
    Console.Write("Id:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome:");
    string nome = Console.ReadLine();
    Console.Write("Salario:");
    double salario = double.Parse(Console.ReadLine());
    list.Add(new Employers(id, nome, salario));
    Console.WriteLine();
}

Console.Write("Insira o ID do funcionario que terá o aumento de salario: ");
int searchId = int.Parse(Console.ReadLine());

Employers emp = list.Find(x => x.ID == searchId);
if (emp != null)
{
    Console.Write("Insira a porcentagem: ");
    double porcentagem = double.Parse(Console.ReadLine());
    emp.AumentoSalario(porcentagem);
}
else
{
    Console.WriteLine("Este funcionario não existe!");
}
Console.WriteLine();
Console.WriteLine("Lista de funcionarios atualizada: ");
foreach (Employers obj in list)
{
    Console.WriteLine(obj);
}
