﻿using Sparrow.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.Repository
{
    public interface IActividadRepository
    {
        void agregarActividad(Actividad actividad);
        IEnumerable<Object> listarActividades();
        IEnumerable<Object> listarActividades(DateTime fechaInicio, DateTime fechaFin);
    }
}
