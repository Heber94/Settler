﻿using System;

namespace TodosLosEventos
{
	public class Plaga : Evento
	{
		System.Random rnd = new System.Random();

		public Plaga()
		{
			Nombre = "Plague";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * There is a plague among your crops! What do you want to do?
			 */

			int chosed;

			/* TODO
			* Mostrar una lista con las opciones.
			* 1. You can take out the air of the infected farm, if you do it just the right time, you'll kill the plague but not the crops.
			* 2. Ignore it, those bugs also have the right to live.
			*/
			if (chosed == 2) 
			{
				solucionado = false;
				FechaFin = FechaInicio + new Fecha (0, 0, 72, 0);
			} 
			else 
			{
				solucionado = true;
				FechaFin = FechaInicio + new Fecha (0, 20, 0, 0);
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
				* You ignored the pague and that has made an impact on your crops.
				*/

				/* TODO
				* Reducir un cierto porcentaje la comida disponible.
				*/
			} 
			else 
			{
				int result = rnd.Next (100);
				if (result <= 20) 
				{
					/* TODO
					 * Mostrar en la interfaz el siguiente texto:
					 * Taking out the air didn't go well, you've lost air and food.
					 */

					/* TODO
					* eliminar un cierto porcentaje de aire y comida.
					*/
				} 
				else 
				{
					/* TODO
					* Mostrar en la interfaz el siguiente texto:
					* You managed to kill the plague without killing your crops, you've lost some air in the proccess.
					*/

					/* TODO
					* eliminar un cierto porcentaje de aire.
					*/
				}
			}
		}
	}
}

