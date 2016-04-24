using System;

namespace TodosLosEventos
{
	public class NuevoSatelite : Evento
	{
		public NuevoSatelite()
		{
			Nombre = "New satelite";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * A new GPS probe sent by ESA has arrived and it will be added to your network.
			 */

			solucionado = 1;
			FechaFin = FechaInicio + new Fecha (0, 10, 0, 0, 0);
		}

		public override void Tick()
		{
		}
		public override void Fin()
		{
			if (solucionado == 1) 
			{
				/* TODO
				* Mostrar en la interfaz el siguiente texto:
				* The new ESA satelite is online over the coordinates (las que sean).
				*/

				/* TODO
				* añadir un satélite sobre esas coordenadas (probablemente elegidas de manera random entre partes del mapa no cubiertas.
				*/
			} 
		}
	}
}

