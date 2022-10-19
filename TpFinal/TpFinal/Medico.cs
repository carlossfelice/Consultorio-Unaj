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
		private string nombreMedico;
		private Turno turnoMedico=null;
		private ArrayList lista_Turnos=new ArrayList();
		/*
		Un médico tiene registrada la información de los turnos dados en el día:

 		nombre paciente y hora de la cita (string hh:mm).
 		
 		**el médico tiene un array de turnos
*/
	
		public Medico(){}
		
		public Medico(string medico,Turno turno){
			this.nombreMedico=medico;
			this.turnoMedico=turno;
			//lista_Turnos.Add(turnoMedico =new Turno());
		
		}
		
		public void ImprimirMedico(){
			if(turnoMedico !=null){
				Console.WriteLine("NombreMedico: {0}",
				                  nombreMedico
				                 );
				turnoMedico.ImprimirTurno();
				
			}
			else{
				Console.WriteLine("{NombreMedico: {0}}",
				                  nombreMedico
				                 );
			}
		}
		
		
	}
}
