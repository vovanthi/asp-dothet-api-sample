using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    public class Conditions
    {
        [DisplayName("shortName")]
        [Required(ErrorMessage = "MESSAGEID001, 0, {0}")]
        [StringLength(10)]
        public string name { get; set;}
    }
}