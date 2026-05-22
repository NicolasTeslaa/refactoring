// versão com código ruim, mal otimizado e ferindo os principios abaixo:
// Single Responsibility Principle
// fere o SRP devido que, a classe calculate, está calculando 3 impostos diferentes
// toda vez que mudar alguma aliquota será necessário alterar essa classe
// Open Closed Principle
// Obsessão por tipos primitivos 

public class calculateBeforeRefactore(decimal amount, string taxType)
{
    public decimal calculate()
    {
        if (taxType == "ICMS")
            return (amount * 4) / 100;

        if (taxType == "ISS")
            return (amount * 11) / 100;

        if (taxType == "IPI")
            return (amount * 15) / 100;
    }
}

public class calculateAfterRefactore()
{

}