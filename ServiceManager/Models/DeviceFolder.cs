using ServiceManager.Data;
using ServiceManager.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceManagerAPI.Models
{
    public class DevicesFolder : IEntity
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nazwa")]
        //[RemoteClientServer("NameExists", "DevicesFolders", ErrorMessage = "Kartoteka z proponowaną nazwą już istnieje", AdditionalFields = "DevicesFolderId")]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Producer")]
        public Guid ProducerId { get; set; }

        [Required]
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }


        public Producer Producer { get; set; }
        public Category Category { get; set; }
    }
}
