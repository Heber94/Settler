using System;

namespace TodosLosEventos
{
	public class NuevaTorre : Evento
	{
		public NuevaTorre()
		{
			Nombre = "New GPS tower";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * You've found the old USSR's Mars 3 lander. You beieve you could use as a repeater for your GPS network.
			 */

			/* TODO
			* Mostrar una lista con las opciones.
			* 1. Invest some materials on getting the probe online.
			* 2. Ignore it, those red machines are evil.
			*/
			if (chosed == 2) 
			{
				solucionado = 0;
				FechaFin = FechaInicio + new Fecha (10, 0, 0, 0, 0);
			} 
			else 
			{
				solucionado = 1;
				FechaFin = FechaInicio + new Fecha (0, 30, 1, 0, 0);
			}
		}

		public override void Tick()
		{
		}
		public override void Fin()
		{
			if (solucionado == 1) {
				/* TODO
				* Mostrar en la interfaz el siguiente texto:
				* You repaired the probe and it's now online on the coordinates (las que sean).
				*/

				/* TODO
				* añadir una torre sobre esas coordenadas (probablemente elegidas de manera random entre partes del mapa no cubiertas.
				* reducir X cantidad de materiales.
				*/
			} 
			else 
			{
				/* TODO
				 * Mostrar en la interfaz el siguiente texto:
				 * You decide to leave the good old Mars 3 alone, you'll build your own network.
				 */ 
			}
		}
	}
}