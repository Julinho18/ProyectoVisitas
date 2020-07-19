using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeVisitas.Shared.Entidades
{
    public class Trabajador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Co_Trabajador { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string No_Trabajador { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Ap_Paterno_Trabajador { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Ap_Materno_Trabajador { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Tipo_Documento { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nu_Documento { get; set; }
        public string Biografia { get; set; }
        public string Imagen { get; set; }
        public string Estado { get; set; }
        public override bool Equals(object obj)
        {// Este metodo Equals SIRVE para el buscador por nombre
            if (obj is Trabajador p2)
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
                if (string.IsNullOrWhiteSpace(No_Trabajador))
                {
                    return null;
                }
                if (No_Trabajador.Length > 60)
                {
                    return No_Trabajador.Substring(0, 60) + "...";
                }
                else
                {
                    return No_Trabajador;
                }
            }
        }
        public int OficinaId { get; set; }
        //lo siguiente sirve para acceder más rápido a Tm_Oficina
        public Oficina Oficina { get; set; }
        public int CargoLaboralId { get; set; }
        //lo siguiente sirve para acceder más rápido a Tm_Cargo_Laboral
        public CargoLaboral CargoLaboral { get; set; }
        
    }
}
