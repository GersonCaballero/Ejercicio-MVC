using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EjercicioPractico.Models
{
    public class Alquiler
    {
        [Key]
        public int Id { get; set; }
        public int IdUser { get; set; }

        public int IdCoche { get; set; }


    }
}