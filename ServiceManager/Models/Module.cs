using ServiceManager.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ServiceManagerAPI.Models
{
    public class Module : IEntity
    {
        public Guid Id { get; set; }

        [ForeignKey("Device")]
        public Guid DeviceId { get; set; }

        [Required]
        [StringLength(50)]
        //[RegularExpression("^([A-Za-z]{3}\\s?[0-9]{8}|[A-Za-z]{2}\\s?[0-9]{8}|[A-Za-z]{3}\\s?[0-9]{10})$", ErrorMessage = "Błędny numer unikatowy")]
        public string UniqueNumber { get; set; }

        public bool Active { get; set; }
        public string Status { get; set; }

        [JsonIgnore]
        public virtual Device Device { get; set; }
    }
}
