using System;

namespace TodosLosEventos
{
	public class TrappedAstronaut : Evento
	{
		System.Random rnd = new System.Random();

		int fugado;
		int maxFugado;

		public TrappedAstronaut()
		{
			Nombre = "Trapped Astronaut";
			FechaInicio = GestorTiempo.fechaActual;
		}
		public override void Inicio()
		{

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * One of your workers was taking some soil samples near the base when he fell into a ravine.
			 */

			int chosed;
			FechaFin = FechaInicio + new Fecha (0, 0, 3, 0, 0);

			/* TODO
			* Mostrar una lista con las opciones.
			* 1. Send someone to recue him.
			* 2. Leave him, he has to learn to survive for himself.
			*/
			if (chosed == 2) 
			{
				solucionado = false;
			} 
			else 
			{
				solucionado = true;
			}
		}

		public override void Tick()
		{
		}
		public override void Fin()
		{
			int result = rnd.Next (100);
			if (!solucionado) 
			{
				if (result <= 20) 
				{
					/* TODO
					* Mostrar en la interfaz el siguiente texto:
					* It looks like your workers are not Matt Damon and the trapped man managed to get back to the base by himself.
					* He even brought the soil samples!
					*/

					/* TODO
					* Añadir X a la ciencia.
					*/
				} 
				else 
				{
					/* TODO
					* Mostrar en la interfaz el siguiente texto:
					* In the end, your trapped worker never came back. The planet owns him now.
					*/

					/* TODO
					* Reducir en uno la población.
					*/
				}
			} 
			else 
			{
				if (result <= 20) 
				{
					/* TODO
					 * Mostrar en la interfaz el siguiente texto:
					 * The astronaut you send to rescue the trapped one has turned out to be too clumsy for the task and both have been lost in the darkness of the ravine.
					 */

					/* TODO
					* Reducir en dos la población.
					*/
				} 
				else 
				{
					/* TODO
					* Mostrar en la interfaz el siguiente texto:
					* Your worker has been rescued and he's back at the base safe and sound.
					*/
				}
			}
		}
	}
}


