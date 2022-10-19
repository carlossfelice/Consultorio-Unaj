/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 17/10/2022
 * Time: 15:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TpFinal
{
	/// <summary>
	/// Description of Horario.
	/// </summary>
	public class Horario
	{
		//atributo
		//private ArrayList horarios=new ArrayList();
		//DateTime horario=new DateTime();
		private int dia, hora, minutos;
		//constructores
		public Horario(){}
		public Horario(int dia,int hora,int minutos){
			this.dia=dia;
			this.hora=hora;
			this.minutos=minutos;

		}
		//propiedades
		
		public int Dia{			set{dia=value;}		get{return dia;}}
		public int HoraMateria{	set{hora=value;}	get{return hora;}}
		public int Minutos{	    set{minutos=value;} get{return minutos;}}
		
		//metodos
		public void ImprimirHorario(){
			Console.WriteLine("Dia: {0},Hora: {1},minutos: {2}",dia,hora,minutos);
		}
	
	}
}
