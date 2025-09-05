using System.ComponentModel.DataAnnotations;

namespace ContractSystem.Models
{
    public class Claims
    {
        public int LecId { get; set; }
        public string Name { get; set; }
        public string Claim { get; set; }
        [Required]
        public decimal Amount { get; set; }
         
    }
}
