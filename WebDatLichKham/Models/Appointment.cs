using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatLichKham.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public int ScheduleId { get; set; }

        [ForeignKey("ScheduleId")]
        public Schedule? Schedule { get; set; }

        [Required]
        public DateTime BookingDate { get; set; } = DateTime.Now;

        [StringLength(500)]
        public string? Note { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Pending";
    }
}