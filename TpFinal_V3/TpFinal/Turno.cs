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
		private string nombrePTurno,HoraTurno;
		//private ArrayList ListaPacTur=new ArrayList();
		//atributos
		//el turno tiene un nombre de paciente y la hora del turno
		//**el turno tiene un nombre de paciente y la hora del turno
		
		
		//constructores
		public Turno(){}
		public Turno(string turno,string nombre){
			this.nombrePTurno=nombre;
			this.HoraTurno=turno;
		}
		
		//propiedades
		public string Turnohora{
			set{HoraTurno=value;}get{return HoraTurno;}
		}
		public string NombrePTurno{
			set{nombrePTurno=value;}get{return nombrePTurno;}
		}
		
		//metodos
		public void ImprimirTurno(){
			Console.Clear();
			Console.ForegroundColor= ConsoleColor.DarkRed;
			Console.WriteLine(
				"Turno Guardado Exitosamente!"+"\n"+
				"Paciente:"	+"\n"+
				nombrePTurno+"\n"+
				"Turno"		+"\n"+
				HoraTurno
			);
		}
		
	}
}