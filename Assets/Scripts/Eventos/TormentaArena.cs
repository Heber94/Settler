using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodosLosEventos
{
    public class TormentaArena : Evento
    {
		/* TODO
		 * Cambiar la clase a como sea que se llame la clase edificio.
		 */
	 	//private  Edificio EdificioReforzado;

		System.Random rnd = new System.Random();

       public TormentaArena()
        {
            Nombre = "Sandstorm";
            FechaInicio = GestorTiempo.fechaActual;
        }
        public override void Inicio()
        {
			FechaFin = FechaInicio + new Fecha (0, 5, 0, 0, 0);

			/* TODO
			 * Mostrar una interfaz con el siguiente texto:
			 * A sandstom aproaches! You have to check the enforcements of the base, 
			 * but you only have time to check one of them. Which one do you choose?
			 */

			/* TODO
			 * Mostrar una lista con los edificios de la base.
			 * El jugador podrá elegir uno de ellos y a este edificio se le aplicará un incremento temporal de la resistencia.
			 */

			/* TODO
			 * Incrementar la resistencia del edificio.
			 */

			//En este caso siempre ocurrirá algo, no hay una opción ganadora.
			solucionado = false;
        }

        public override void Tick()
        {

        }
        public override void Fin()
        {
            if (!solucionado)
            {
				int daño;
                /* TODO
                 * Ciclar entre todos los edificios.
                 */
				//foreach (Edificio e in Edificios)  
				{
					daño = rnd.Next(100);
					/* TODO
					 * Poner los métodos que realmente correspondan.
					 */
					//if (e.resistencia < daño) 
					{
					//	e.destroy ();
					}
					//if (e.equals (EdificioReforzado)) 
					{
						/* TODO
						 * Quitar el refuerzo previamente aplicado.
						 */
					}
				}

				/* TODO
				 * Mostrar los resultados en la interfaz.
				 */
            }
        }
    }
}
