using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaDeVisitas.Shared.Entidades
{
    public class Visita
    {
        public int Id { get; set; }
        public DateTime? Fe_Registro { get; set; }
        public string Co_Pase { get; set; }
        public DateTime? Fe_Ingreso { get; set; }
        public DateTime? Fe_Salida { get; set; }
        public string No_Usuario_Registro { get; set; }
        public string No_Usuario_Modificación { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string No_Lugar_Reunion { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Motivo { get; set; }
        public string No_Estado { get; set; }
        public int VisitanteId { get; set; }
        //lo siguiente sirve para acceder más rápido a Tm_Visitante
        public Visitante Visitante { get; set; }
        public int TrabajadorId { get; set; }
        //lo siguiente sirve para acceder más rápido a Tm_Trabajador
        public Trabajador Trabajador { get; set; }
    }
}
