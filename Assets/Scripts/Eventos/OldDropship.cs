using System;

namespace TodosLosEventos
{
	public class OldDropship : Evento
	{
		System.Random rnd = new System.Random();

		int fugado;
		int maxFugado;

		public OldDropship()
		{
			Nombre = "Old Dropship Found";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * Your sensors have found an old NASA's dropship orbiting the planet. you could try to controle it remotely and take it to the base.
			 */

			int chosed;

			/* TODO
			* Mostrar una lista con las opciones.
			* 1. Try to retrieve the dropship (spend X science).
			* 2. Leave it, it looks really peacefull randomly surfing through that excentric orbit.
			*/
			if (chosed == 2) 
			{
				FechaFin = FechaInicio + new Fecha (0, 0, 0, 2, 0);
				solucionado = false;
			} 
			else 
			{
				solucionado = true;
				FechaFin = FechaInicio + new Fecha (0, 0, 0, 1, 0);
			}
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
				* You decided to leave the dropship be, not much time passes until it falls into the atmosphere due to orbit decay and gets destroyed.
				*/
			} 
			else 
			{
				int result = rnd.Next (100);
				if (result <= 20) 
				{
					/* TODO
					 * Mostrar en la interfaz el siguiente texto:
					 * You try to get the dropship to your base but you are no Han Solo and end up crashing it into one of the buildings.
					 */

					/* TODO
					* eliminar un cierto porcentaje de ciencia.
					* Destruir un edificio aleatorio.
					*/
				} 
				else 
				{
					/* TODO
					* Mostrar en la interfaz el siguiente texto:
					* You managed to get the dropship to the base and recover usefull resources from it.
					*/

					/* TODO
					* eliminar un cierto porcentaje de ciencia.
					* añadir X cantidad de materiales, aire y agua.
					*/
				}
			}
		}
	}
}

