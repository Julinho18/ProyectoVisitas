using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeVisitas.Shared.Entidades
{
    public class Visitante
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string No_Visitante { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Ap_Paterno_Visitante { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Ap_Materno_Visitante { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Tipo_Documento { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nu_Documento { get; set; }
        public string Imagen { get; set; }
        public override bool Equals(object obj)
        {// Este metodo Equals SIRVE para el buscador por nombre
            if (obj is Visitante p2)
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
                if (string.IsNullOrWhiteSpace(No_Visitante))
                {
                    return null;
                }
                if (No_Visitante.Length > 60)
                {
                    return No_Visitante.Substring(0, 60) + "...";
                }
                else
                {
                    return No_Visitante;
                }
            }
        }
        public int InstitutoId { get; set; }
        //lo siguiente sirve para acceder más rápido a Tm_Instituto
        public Instituto Instituto { get; set; }
    }
}
