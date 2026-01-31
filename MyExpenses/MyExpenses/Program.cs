using System;

class Program
{
    static void Main()
    {
        try
        {
            Greeting();
            int year = Convert.ToInt32(Console.ReadLine());
            int age = CalculateAgeByYear(year);
            Console.WriteLine("Sua idade:" + age);
            ValidateComingOfAge(age);
        }catch(AccessViolationException err) 
        {
            Console.WriteLine("Erro de permissão" + err.Message);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Fim do Software");
        }
    }

    public static int CalculateAgeByYear(int YearOfBirth)
    {
        return DateTime.Now.Year - YearOfBirth;
    }

    public static void ValidateComingOfAge(int age)
    {
        if (age < 18) throw new AccessViolationException("Pessoa menor de idade");
    }

    public static void Greeting() {
        Console.WriteLine("Controle de acesso");
        Console.WriteLine("Digite o Ano de seu Nascimento");
    }
}
