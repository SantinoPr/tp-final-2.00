using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final_2
{
    class Equipo
    {
        int faltas;
        int cont = 0;
        Jugador[] jugador = new Jugador[5];
        string nombreEquipo;
        
      
        public void CrearJ(string nombre, int num)
        {
            jugador[cont] = new Jugador(num, nombre);//se crean los jugadores
            cont++;
        }


        public void NombreEquipo(string nombre)//se ingresa el nombre del equipo
        {
            nombreEquipo = nombre;

        }
        public int PuntosJuga(int indice)//puntos de cada jugador
        {
            return jugador[indice].Puntos;
        }
        public string NombreE//retorna el nombre del equipo
        {
            get { return nombreEquipo; }
        }


        public void Anotar(int tanto, int indice)//anotacion de los puntos
        {
            jugador[indice].Marcador(tanto);

        }
        public void burbuja()//metodo de ordenamiento
        {
            Jugador aux = new Jugador(0, "cero");
          
            bool bandera = false;

            for (int i = 0; i < jugador.Length - 1; i++)
            {
                if (bandera)
                {
                    break;
                }
                bandera = true;
                for (int j = 0; j < jugador.Length - 1; j++)
                {
                    if (jugador[j].Puntos > jugador[j + 1].Puntos)
                    {
                        
                        aux = jugador[j];
                        jugador[j] = jugador[j+1];
                        jugador[j+1] = aux;
                        bandera = false;

                    }
                }
            }
        }
        public string Nom(int indice)//retorna solo el nombre del jugador
        {
            return jugador[indice].Nombre;

        }


        public int PuntosTotales()//puntos totales realizados por el equipo
        {
            int acum = 0;

            for (int i = 0; i < 5; i++)
            {
                acum += jugador[i].Puntos;

            }
            return acum;
        }


        public void Faltas(int indice)//faltas cometidas por el jugador guardado en el indice
        {
            jugador[indice].Falta();
            faltas++;

        }

        public int FaltasTotales()//faltas totales del equipo
        {
            int acum = 0;

            for (int i = 0; i < 5; i++)
            {
                acum += jugador[i].faltastotales;

            }

            return acum;
        }

        public bool PuedeJugar(int indice)
        {
            return jugador[indice].PuedeJugar();

        }

        public string Mayores()//jugador que mas tantos hizo
        {
            string Mayornombre = "";
            int Mayorpuntos = 0;

            for (int i = 0; i < 5; i++)
            {
                if (jugador[i].Puntos > Mayorpuntos)
                {
                    Mayorpuntos = jugador[i].Puntos;
                    Mayornombre = jugador[i].Nombre;
                }

            }

            return String.Format("{0} - {1} en total", Mayornombre, Mayorpuntos);


        }

        public string Menores()//jugador que menos tanto realizo
        {
            string Menornombre = "";
            int Menorpuntos=PuntosTotales();

            for (int i = 0; i < 5; i++)
            {
                if (jugador[i].Puntos < Menorpuntos)
                {
                    Menorpuntos = jugador[i].Puntos;
                    Menornombre = jugador[i].Nombre;
                }

            }

            return String.Format("{0} - {1} en total", Menornombre, Menorpuntos);


        }
    }
}
