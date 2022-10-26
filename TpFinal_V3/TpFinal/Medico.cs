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
		private static ArrayList ListaCompletaTurnos   =new ArrayList();
		private static ArrayList listaCompletaPacientes=new ArrayList();
		/*
		Un médico tiene registrada la información de los turnos dados en el día:

 		nombre paciente y hora de la cita (string hh:mm).
 		
		 **el médico tiene un array de turnos
		 * 
					"**************Turnos****************"+"\n"+
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
		public Medico(){}
		
		//metodos ****Turno****
		public static void AgregarTurno(Turno turno)		{ListaCompletaTurnos.Add(turno);}
		public static void EliminarTurno(Turno turno)		{ListaCompletaTurnos.Remove(turno);}
		public static ArrayList TodosLosTurnos()			{return ListaCompletaTurnos;}
		//public ArrayList TodoslosTurnosObraSocial(){}
		//metodos ****Pacientes****
		public static void AgregarPaciente(Paciente pac)	{listaCompletaPacientes.Add(pac);}
		public static void EliminarPaciente(Paciente pac)	{listaCompletaPacientes.Remove(pac);}
		public static void ModificarPaciente(){}
		public static ArrayList TodosLosPacientes()			{return ListaCompletaTurnos;}
		//public void ListadoPacientes(){return listaCompletaPacientes;}
		
		
		
		
	}
}
