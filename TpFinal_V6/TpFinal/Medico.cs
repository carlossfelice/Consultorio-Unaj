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
		/*
		Un médico tiene registrada la información de los turnos dados en el día:
 		nombre paciente y hora de la cita (string hh:mm).
		 **el médico tiene un array de turnos
		 */
		//constructor
		public Medico()
		{
			turnos=new ArrayList(9);
			
			turnos.Add(new Turno("08:00",null,"libre"));
			turnos.Add(new Turno("08:30",null,"libre"));
			turnos.Add(new Turno("09:00",null,"libre"));
			turnos.Add(new Turno("09:30",null,"libre"));
			turnos.Add(new Turno("10:00",null,"libre"));
			turnos.Add(new Turno("10:30",null,"libre"));
			turnos.Add(new Turno("11:00",null,"libre"));
			turnos.Add(new Turno("11:30",null,"libre"));
			turnos.Add(new Turno("12:00",null,"libre"));
			
			pacientes=new ArrayList();
			
		}
		//propiedades
		//***********turnos*********
		public ArrayList Turnos{get{return turnos;}}
		//***********pacientes*********
		public ArrayList Pacientes{get{return pacientes;}}
		
		
		//metodos
		//*******************************Turno******************************
		public void agregarTurno(Turno turno)		{Turnos.Add(turno);}
		public void eliminarTurno(Turno turno)		{Turnos.Remove(turno);}
		
		public Turno verTurno(int indice){return(Turno)turnos[indice];}

		
		//****************************Pacientes******************************
		public void agregarPaciente(Paciente pacienteNuevo)	{Pacientes.Add(pacienteNuevo);}
		public void eliminarPaciente(Paciente eliminarPac)	{Pacientes.Remove((Paciente) eliminarPac);}
		
		public Paciente verPaciente(int indice){return(Paciente)pacientes[indice];}
		
		public int cantPacientes(){return pacientes.Count;}
		
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
	}
}
