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
		//decidi guardar no solo el nombre del paciente sino guardar el paciente y
		//guardar todos los pacientes;lo mismo para turnos
		
		private  ArrayList turnos=null;
		private  ArrayList pacientes=null;
		/*
		Un médico tiene registrada la información de los turnos dados en el día:
 		nombre paciente y hora de la cita (string hh:mm).
		 **el médico tiene un array de turnos
		 */
		//constructor
		public Medico(){
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
		//****Turno****
		public void agregarTurno(Turno turno)		{Turnos.Add(turno);}
		public void eliminarTurno(Turno turno)		{Turnos.Remove(turno);}
		
		public Turno verTurno(int indice){return(Turno)turnos[indice];}

		//public int todosLosTurnos(){return turnos;}
		
		//****Pacientes****
		public void agregarPaciente(Paciente pac)	{Pacientes.Add(pac);}
		public void eliminarPaciente(Paciente pac)	{Pacientes.Remove(pac);}
		
		public Paciente verPaciente(int indice){return(Paciente)pacientes[indice];}
		public int cantPacientes(){return pacientes.Count;}
		public int existePaciente(int nro){
			foreach (Paciente pac in pacientes) {
				if (pac.NroAfiliado==nro) {
					return pacientes.IndexOf(pac);
				}
			}
			return -1;
		}
		//existe puede ser un bool o devolver la posicion de la lista

		
		public ArrayList todosLosPacientes(){return pacientes;}
		
		//Faltan algunos métodos básicos como
		//verPaciente, verTurno, cantPacientes, existePaciente.
		/*
		 * 		"**************Turnos****************"+"\n"+
					"1) Agregar turno"+"\n"+
					"2) Eliminar Turno"+"\n"+
					"3) Listado de turnos"+"\n"+
					"4) Listado de obras sociales"+"\n"+
					"**************Pacientes****************"+"\n"+
					"5) Agregar paciente"+"\n"+
					"6) Modificar el diagnóstico de un paciente"+"\n"+
					"7) Eliminar paciente"+"\n"+
					"8) Listado de paciente"+"\n"+
		 */
		
	}
}
