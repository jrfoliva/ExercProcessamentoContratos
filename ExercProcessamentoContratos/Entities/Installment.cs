using System.Globalization;
namespace ExercProcessamentoContratos.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; } //Vencimento
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                 + " - "
                 + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
