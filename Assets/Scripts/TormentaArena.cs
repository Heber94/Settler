using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodosLosEventos
{
    public class TormentaArena : Evento
    {

       public TormentaArena()
        {
            Nombre = "Tormenta de Arena";
            FechaInicio = GestorTiempo.fechaActual;
        }
        public override void Inicio()
        {

        }

        public override void Tick()
        {

        }
        public override void Fin()
        {
            if (!solucionado)
            {
                //  Recursos.eliminar(10, 1, 1);
            }
        }
    }
}
