namespace MVCApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Locations Locations  { get; set; }
    }
}
