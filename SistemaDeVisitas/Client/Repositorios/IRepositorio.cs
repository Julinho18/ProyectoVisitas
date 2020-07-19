using SistemaDeVisitas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVisitas.Client.Repositorios
{
    //Una interfaz me permite definir un conjunto de signaturas de métodos los cuales otras clases van a tener que implementar
    public interface IRepositorio
    {
        List<CargoLaboral> ObtenerCargoLaborales();
        List<Instituto> ObtenerInstitutos();
        List<Oficina> ObtenerOficinas();
        List<Trabajador> ObtenerTrabajadores();
        List<Visitante> ObtenerVisitantes();
        List<Visita> ObtenerVisitas();
    }
}
