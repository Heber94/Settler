using System;

namespace TodosLosEventos
{
	public class Nubes : Evento
	{
		public Nubes()
		{
			Nombre = "Clouds";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * It seems like it's going to be a cloudy day.
			 * Solar production is not going to be very eficient today.
			 */

			/* TODO
			 * Ciclar entre todos los edificios de producción de energía y reducir su producción a la mitad.
			 */
			FechaFin = FechaInicio + new Fecha (0, 0, 24, 0);
			//No se puede evitar
			solucionado = false;
		}

		public override void Tick()
		{
		}
		public override void Fin()
		{
			if (!solucionado) 
			{
				/* TODO
				* Mostrar en la interfaz el siguiente texto:
				* The skies look clear again.
				*/

				/* TODO
				 * Devolver la producción de los edificios a sus valores originales.
				 */
			} 
		}
	}
}

