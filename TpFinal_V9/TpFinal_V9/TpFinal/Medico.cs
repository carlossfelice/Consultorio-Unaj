/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 16/10/2022
 * Time: 17:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace TpFinal
{
	/// <summary>
	/// Description of Medico.
	/// </summary>
	public class Medico
	{
		
		//atributos
		private  ArrayList turnos;
		private  ArrayList pacientes;
		
		private int capacidadTurnos=0;
		
		private int contadorOcupados=0;
		
		private int capacidadPacientes=0;
		
		private int contadorPacientes=0;
		
		/*
		Un médico tiene registrada la información de los turnos dados en el día:
 		nombre paciente y hora de la cita (string hh:mm).
		 **el médico tiene un array de turnos
		 */
		//constructor
		public Medico()
		{
			turnos=new ArrayList();
			
			turnos.Add(new Turno("08:00",null,"libre"));
			turnos.Add(new Turno("08:30",null,"libre"));
			turnos.Add(new Turno("09:00",null,"libre"));
			turnos.Add(new Turno("09:30",null,"libre"));
			turnos.Add(new Turno("10:00",null,"libre"));
			turnos.Add(new Turno("10:30",null,"libre"));
			turnos.Add(new Turno("11:00",null,"libre"));
			turnos.Add(new Turno("11:30",null,"libre"));
			turnos.Add(new Turno("12:00",null,"libre"));
			
			capacidadTurnos=9;
			pacientes=new ArrayList();
			//puse poca capacidad para saltar exception
			capacidadPacientes=4;
			
		}
		//propiedades
		//***********turnos*********
		public ArrayList Turnos
		{
			get{return turnos;}
		}
		//********************************
		public int CapacidadTurnos
		{
			get{return capacidadTurnos;}
		}
		//********************************
		public int ContadorOcupados
		{
			get{return contadorOcupados;}
		}
		
		//***********pacientes*********
		public ArrayList Pacientes
		{
			get{return pacientes;}
		}
		//********************************
		public int CapacidadPacientes
		{
			get{return capacidadPacientes;}
		}
		//metodos
		
		//*******************************************************************
		//**************************TURNOS***********************************
		//*******************************************************************
		public void turnosDisponibles()
		{
			Console.WriteLine("Turnos Disponibles :");
			foreach (Turno turnolibre in Turnos)
			{
				if (turnolibre.EstadoTurno=="libre")
				{
					Console.WriteLine(turnolibre.HoraTurno);
				}
			}
		}
		public int cantidadTurnos()
		{
			return turnos.Count;
			
		}

		/********************************************************************/
		public void agregarTurno(string horaTurno,string nombrePaciente)
		{
			foreach(Turno turnoActual in Turnos)
			{
				if(turnoActual.HoraTurno==horaTurno)
				{
					if(turnoActual.EstadoTurno=="libre")
					{
						turnoActual.EstadoTurno="ocupado";
						turnoActual.NombrePTurno=nombrePaciente;
						
						contadorOcupados++;
						
					}
				}
			}
			
		}
		/********************************************************************/
		public void eliminarTurno(string hora,string nombre)
		{
			foreach (Turno TurnoDesocupar in Turnos)
			{
				if(TurnoDesocupar.HoraTurno==hora){
					if(TurnoDesocupar.EstadoTurno=="ocupado")
					{
						TurnoDesocupar.EstadoTurno="libre";
						TurnoDesocupar.NombrePTurno=null;
					}
				}
			}
			
		}
		/********************************************************************/
		public void listadoTurnos()
		{
			foreach(Turno turnosLCompletos in Turnos )
			{
				turnosLCompletos.ImprimirTurno();
			}
		}
		/********************************************************************/
		public void listadoObraSocial()
		{
			ArrayList temporalObraSocial=new ArrayList();
			foreach (Paciente pacienteActual in Pacientes)
			{
				if(!temporalObraSocial.Contains(pacienteActual.ObraSocial))
				{
					temporalObraSocial.Add(pacienteActual.ObraSocial);
				}
			}
			foreach (string obraSocialfiltrado in temporalObraSocial)
			{
				Console.WriteLine(obraSocialfiltrado);
			}

		}
		/********************************************************************/
		public Turno verTurno(int indice){return(Turno)turnos[indice];}

		//*******************************************************************
		//****************************Pacientes******************************
		//*******************************************************************
		public int cantidadPacientes()
		{
			return pacientes.Count;
		}
		/********************************************************************/
		public void agregarPaciente(Paciente unPaciente)
		{
			pacientes.Add(unPaciente);
			
			contadorPacientes++;
		}
		/********************************************************************/
		public void modificarDiagnostico(int documento,string diagnostico)
		{
			foreach (Paciente pacienteModificar in Pacientes)
			{
				if (pacienteModificar.DNI==documento)
				{
					pacienteModificar.Diagnostico=diagnostico;
				}
			}
		}


		/*******************************************************************************/
		public void eliminarPaciente(int documento)
		{
			foreach (Paciente pacienteEliminar in Pacientes)
			{
				if (pacienteEliminar.DNI==documento)
				{
					Pacientes.Remove(pacienteEliminar);
					break;
					//use break por que si lo encontro ,no seguir buscando mas
				}
			}

		}
		/*******************************************************************************/
		public  void listadoPaciente()
		{
			foreach (Paciente listaPacientes in Pacientes) {
				listaPacientes.ImprimirPaciente();
			}
		}
		/*******************************************************************************/
		public Paciente verPaciente(int indice){return(Paciente)pacientes[indice];}
		/*******************************************************************************/
		public int cantPacientes(){return pacientes.Count;}
		/*******************************************************************************/
		public int existePaciente(int nro)
		{
			foreach (Paciente pac in pacientes)
			{
				if (pac.NroAfiliado==nro)
				{
					return pacientes.IndexOf(pac);
				}
			}
			return -1;
		}
		/*******************************************************************************/
		
	}
}
