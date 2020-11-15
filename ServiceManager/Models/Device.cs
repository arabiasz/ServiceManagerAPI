using ServiceManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ServiceManagerAPI.Models
{
    public class Device : IEntity
    {
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("DevicesFolder")]
        public Guid DevicesFolderId { get; set; }

        [Required]
        [StringLength(50)]
        public string SerialNumber { get; set; }

        [StringLength(50)]
        public string RegistrationNumber { get; set; } 

        [Range(1, 48)]
        public int ReviewInterval { get; set; }       

        [Range(1, 48)]
        public int WarrantyInterval { get; set; }

        public DateTime InterimReviewDate { get; set; }

        [JsonIgnore]
        public DevicesFolder DevicesFolder { get; set; }

        [JsonIgnore]
        public virtual ICollection<Module> Modules { get; set; }
    }
}
