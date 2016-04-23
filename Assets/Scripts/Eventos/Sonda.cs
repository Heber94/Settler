using System;

namespace TodosLosEventos
{
	public class Sonda : Evento
	{
		public Sonda()
		{
			Nombre = "Probe found";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * You have discovered an old probe from the USSR space program. Do you want to investigate it?
			 */

			/* TODO
			* Mostrar una lista con las opciones.
			* 1. Investigate the probe.
			* 2. Ignore it.
			*/
			if (chosed == 2) 
			{
				/* TODO
				 * Mostrar en la interfaz el siguiente texto:
				 * You aproach the probe to examine it.
				 */
				solucionado = 1;
				FechaFin = FechaInicio + new Fecha (0, 5, 0, 0, 0);
			} 
			else 
			{
				solucionado = 0;
				FechaFin = FechaInicio + new Fecha (10, 0, 0, 0, 0);
			}
		}

		public override void Tick()
		{
		}
		public override void Fin()
		{
			if (solucionado == 0) 
			{
				/* TODO
				* Mostrar en la interfaz el siguiente texto:
				* You ignored your probe and went on with your life.
				*/
			} 
			else 
			{
				/* TODO
				 * Mostrar en la interfaz el siguiente texto:
				 * You recovered some usefull materials and data from the probe.
				 */

				/* TODO
				* Incrementar X cantidad de ciencia y materiales, no lo he hecho porque faltan los métodos para ello.
				*/
			}
		}
	}
}
