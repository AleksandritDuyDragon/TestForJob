using System;

namespace TestForJob
{
    [Serializable]
    public class Cheque
    {
        public int Number { get; set; }
        public DateTime ChequeDate { get; set; }
        public string Summary { get; set; }
        public Cheque() { }
        public Cheque(int Number, DateTime ChequeDate, string Summary)
        {
            this.Number = Number;
            this.ChequeDate = ChequeDate;
            this.Summary = Summary;
        }
    }
}
