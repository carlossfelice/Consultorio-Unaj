/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 15/10/2022
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Linq.Expressions;

namespace TpFinal
{
	/// <summary>
	/// Description of Turno.
	/// </summary>
	public class Turno
	{
		//atributos
		//el turno tiene un nombre de paciente y la hora del turno
		
		//**el turno tiene un nombre de paciente y la hora del turno
		//private string tmedico;
		private string especialidad;
		private Horario thora=null;
		private Paciente tpaciente=null;
		//constructores
		public Turno(){}
		public Turno(string especialidad,Horario hora,Paciente paciente){
			this.especialidad=especialidad;
			this.thora=hora;
			this.tpaciente=paciente;
		}
		
		
		//propiedades
		
		
		
		//metodos
		public void ImprimirTurno(){
              if(thora !=null && tpaciente !=null){
			    Console.WriteLine("Especialidad: {0}",
			                  	  especialidad);
								thora.ImprimirHorario();
			                  	tpaciente.ImprimirPaciente();
              }
              else{
				Console.WriteLine("Especialidad: {0} aun no tiene turno asignado",
				                  especialidad
				                 );
			  }
			                 
		}
		
		
		
		
	}
}
