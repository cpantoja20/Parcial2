using System;
using Datos;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Logica
{
    public class EmpresasService
    {
        private readonly EmpresasContext _context;
        public EmpresasService(EmpresasContext context)
        {
            _context = context;

        }
        public GuardarEmpresasResponse Guardar(Empresas empresas)
        {
            try
            {
                _context.Empresas.Add(empresas);
                _context.SaveChanges();
                return new GuardarEmpresasResponse(empresas);
            }
            catch (Exception e)
            {
                return new GuardarEmpresasResponse($"Error de la Aplicacion: {e.Message}");
            }
        }

        public List<Empresas> ConsultarTodos()
        {
            List<Empresas> empresas = _context.Empresas.ToList();
            return empresas;
        }

        public string Eliminar(string codigoP)
        {
            try
            {
                var empresas = _context.Empresas.Find(codigoP);
                if (empresas != null)
                {
                    _context.Empresas.Remove(empresas);
                    return ($"El registro {empresas.NEmpresa} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {codigoP} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
        }
        public string Modificar(Empresas empresaNueva)
        {
            try
            {
                var empresaVieja = _context.Empresas.Find(empresaNueva.IdEmpresa);
                if (empresaVieja != null)
                {
                    _context.Empresas.Update(empresaNueva);
                    return ($"El registro {empresaNueva.NEmpresa} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {empresaNueva.IdEmpresa } no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }

        }

        public Empresas BuscarxIdentificacion(string codigoP)
        {
            Empresas empresas = _context.Empresas.Find(codigoP);
            return empresas;
        }
    }

    public class GuardarEmpresasResponse
    {
        public GuardarEmpresasResponse(Empresas empresas)
        {
            Error = false;
            Empresas = empresas;
        }
        public GuardarEmpresasResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Empresas Empresas { get; set; }
    }
}
