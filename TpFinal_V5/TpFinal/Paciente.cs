/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 16/10/2022
 * Time: 16:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TpFinal
{
	/// <summary>
	/// Description of Paciente.
	/// </summary>
	public class Paciente
	{
		//**y el paciente tiene nombre, dni,obra social, nro afiliado y diagnóstico
		//atributos
		private int nroafiliado,dni;
		private	string nombre,obrasocial,diagnostico;
		
		//constructores
		
		public Paciente(){}
		public Paciente(string nombre,int dni,string obrasocial,
		                int nroafiliado,string diagnostico){
			this.nombre=nombre;
			this.dni=dni;
			this.obrasocial=obrasocial;
			this.nroafiliado=nroafiliado;
			this.diagnostico=diagnostico;
		}
		
		//propiedades
		public string Nombre	{set{nombre=value;}get{return nombre;}}
		public int 		DNI		{set{dni=value;}get{return dni;}}
		public string ObraSocial{set{obrasocial=value;}get{return obrasocial;}}
		public int 	 NroAfiliado{set{nroafiliado=value;}get{return nroafiliado;}}
		public string Diagnostico{set{diagnostico=value;}get{return diagnostico;}}
		//metodos
		public void ImprimirPaciente(){
			Console.WriteLine(
				"***********Informacion de Paciente***********"+"\n"+
				"Nombre:"+"\n"+
				nombre+"\n"+
				"DNI:"+"\n"+
				dni+"\n"+
				"ObraSocial:"+"\n"+
				obrasocial+"\n"+
				"NroAfiliado:"+"\n"+
				nroafiliado+"\n"+
				"Diagnostico:"+"\n"+
				diagnostico+"\n"
			);
		}
	}
}
