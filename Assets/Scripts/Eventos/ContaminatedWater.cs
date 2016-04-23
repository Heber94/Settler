using System;

namespace TodosLosEventos
{
	public class ContaminatedWater : Evento
	{
		public ContaminatedWater()
		{
			Nombre = "Contaminated Water";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * You find out that some of your water resources are contaminated.
			 * Recleaning it is going to take some time and energy.
			 */

			/* TODO
			* Quitar X cantidad de agua.
			*/
			FechaFin = FechaInicio + new Fecha (0, 0, 24, 0);
			//No se puede evitar
			solucionado = false;
		}

		public override void Tick()
		{
			/* TODO
			 * Añadir 1 al agua y quitar 1 a la energie siempre hasta recuperar el agua gastada.
			 */
		}
		public override void Fin()
		{
			if (!solucionado) 
			{
				/* TODO
				* Mostrar en la interfaz el siguiente texto:
				* Seems like all your stored water is clean again.
				*/
			} 
		}
	}
}


