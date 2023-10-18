using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easy_meal_api.Models
{
	public class AlimentDao
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("FK_Aliments_Type_Id")]
        public string TypeId { get; set; }
    }
}

