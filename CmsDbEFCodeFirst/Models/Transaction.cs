namespace CmsDbEFCodeFirst.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Typ { get; set; }
    }


    public class Lan
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}