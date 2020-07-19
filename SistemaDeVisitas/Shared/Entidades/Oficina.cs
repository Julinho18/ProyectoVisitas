using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeVisitas.Shared.Entidades
{
    public class Oficina
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sede { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Co_Oficina { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string No_Oficina { get; set; }
        public string De_Oficina { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Jefe_Oficina { get; set; }
        public string Imagen { get; set; }
        public string Estado { get; set; }
        public override bool Equals(object obj)
        {// Este metodo Equals SIRVE para el buscador por nombre
            if (obj is Oficina p2)
            {
                return Id == p2.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {// Este metodo Equals GEThashcode es el complemento para buscar por nombre
            return base.GetHashCode();
        }
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(No_Oficina))
                {
                    return null;
                }
                if (No_Oficina.Length > 60)
                {
                    return No_Oficina.Substring(0, 60) + "...";
                }
                else
                {
                    return No_Oficina;
                }
            }
        }
    }
}
