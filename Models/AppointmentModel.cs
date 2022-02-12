using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointementMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Pationt's full name")]
        public string PatientName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }

        [Range(90, Double.PositiveInfinity)]
        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate net Worth")]
        public decimal PatienNetworth { get; set; }

        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Range(5,10)]
        [DisplayName("Patient's Perceaived Level of pain")]
        public int PainLevel { get; set; }
    }
}
