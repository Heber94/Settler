using System;

namespace TodosLosEventos
{
	public class Fuga : Evento
	{
		System.Random rnd = new System.Random();

		int fugado;
		int maxFugado;

		public Fuga()
		{
			Nombre = "Air leak";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * One of your buildings has an aire leak. Repair it ASAP!
			 */


			/* TODO
			* Mostrar una lista con las opciones.
			* 1. Repair the leak (spend X materials).
			* 2. Ignore it.
			*/
			if (chosed == 2) 
			{
				fugado = 0;
				/*
			 	 * Sustituir por un número más acorde.
				 */ 
				maxFugado = rnd.Next (100);
				FechaFin = FechaInicio + new Fecha (0, 5, 0, 0, 0);
				solucionado = 0;
			} 
			else 
			{
				solucionado = 1;
				FechaFin = FechaInicio + new Fecha (10, 0, 0, 0, 0);
			}
		}

		public override void Tick()
		{
			if (solucionado == 0 && fugado < maxFugado)
				fugado++;
		}
		public override void Fin()
		{
			if (solucionado == 0) 
			{
				/* TODO
				 * Restar fugado al recurso, no lo he implementado porque no hay ningún método apra borrar recursos a parte de build
				 * y no quería modificar directamente la array a pesar de no ser privada (fallo de seguridad del cópón).
				 */

				/* TODO
				 * Mostrar en la interfaz el siguiente texto:
				 * (fugado) Oxygen units leaked from the building.
				 */
			} 
			else 
			{
				/* TODO
				 * Mostrar en la interfaz el siguiente texto:
				 * You stopped the leak in time.
				 */
			}
		}
	}
}

