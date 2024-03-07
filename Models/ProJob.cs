
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FPT_JOB_Mart.Models
{
    public class ProJob
    {
        [Key]
        public int Id { get; set; }
        public DateTime RegDate { get; set; }

        public int Profile  { get; set; }
        [ForeignKey("Profile")]
        public virtual Profile? ObjProfile { get; set; }

        public int ProId {  get; set; }
        [ForeignKey("JobId")]
        public virtual Job? ObjJob { get; set; }

    }
}
