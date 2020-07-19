using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeVisitas.Shared.Entidades
{
    public class CargoLaboral
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Co_Cargo_Laboral { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string No_Cargo_Laboral { get; set; }
        public string De_Cargo_Laboral { get; set; }
        public string Imagen { get; set; }
        public string Estado { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is CargoLaboral p2)
            {
                return Id == p2.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(No_Cargo_Laboral))
                {
                    return null;
                }
                if (No_Cargo_Laboral.Length > 60)
                {
                    return No_Cargo_Laboral.Substring(0, 60) + "...";
                }
                else
                {
                    return No_Cargo_Laboral;
                }
            }
        }
    }
}
