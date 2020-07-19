using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; /*para poder usar el Required*/
using System.Text;

namespace SistemaDeVisitas.Shared.Entidades
{
    public class Instituto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string No_Instituto { get; set; }
        public string De_Instituto { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Tipo_Documento { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nu_Documento { get; set; }
        public string Imagen { get; set; }
        public string Estado { get; set; }
        public override bool Equals(object obj)
        {// Este metodo Equals SIRVE para el buscador por nombre
            if (obj is Instituto p2)
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
                if(string.IsNullOrWhiteSpace(No_Instituto))
                {
                    return null;
                }
                if(No_Instituto.Length>60)
                {
                    return No_Instituto.Substring(0, 60) + "...";
                }
                else
                {
                    return No_Instituto;
                }
            }
        }
    }
}
