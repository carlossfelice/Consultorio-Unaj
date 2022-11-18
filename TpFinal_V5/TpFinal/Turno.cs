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
		private string horaTurno,nombrePaciente,estado;
		//atributos
		//el turno tiene un nombre de paciente y la hora del turno
		
		//constructores
		public Turno(string horaTurno,string nombrePaciente,string estado){
			this.nombrePaciente=nombrePaciente;
			this.horaTurno=horaTurno;
			this.estado=estado;
		}
		
		//propiedades
		public string HoraTurno{
			set{horaTurno=value;}get{return horaTurno;}
		}
		public string NombrePTurno{
			set{nombrePaciente=value;}get{return nombrePaciente;}
		}
		public string EstadoTurno{
			set{estado=value;}get{return estado;}
		}
		//metodos
		
		public void ImprimirTurno(){
			Console.WriteLine(
			"HoraTurno: "		+"\n"+
			horaTurno			+"\n"+
			"NombrePaciente: "	+"\n"+
			nombrePaciente		+"\n"+
			"Estado: "			+"\n"+
			estado				+"\n"
			);
		}
		
		
	}
}