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
		private	string nombre,dni,obrasocial,nroafiliado,diagnostico;
		//constructores
		
		public Paciente(){}
		public Paciente(string nombre,string dni,string obrasocial,
		                string nroafiliado,string diagnostico){
			this.nombre=nombre;
			this.dni=dni;
			this.obrasocial=obrasocial;
			this.nroafiliado=nroafiliado;
			this.diagnostico=diagnostico;
		}
		
		//propiedades
		public string Nombre	{set{nombre=value;}get{return nombre;}}
		public string DNI		{set{dni=value;}get{return dni;}}
		public string ObraSocial{set{obrasocial=value;}get{return obrasocial;}}
		public string NroAfiliado{set{nroafiliado=value;}get{return nroafiliado;}}
		public string Diagnostico{set{diagnostico=value;}get{return diagnostico;}}
		//metodos
		public void ImprimirPaciente(){
			Console.WriteLine(
				"Nombre: {0}DNI: {1}ObraSocial: {2}NroAfiliado: {3}Diagnostico: {4}"
				,nombre,dni,obrasocial,nroafiliado,diagnostico
			);
		}
	}
}
