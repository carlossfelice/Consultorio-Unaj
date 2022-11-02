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
		
		private string nombrepac,horaCita;
		private  ArrayList turnos   =new ArrayList();
		private  ArrayList pacientes=new ArrayList();
		/*
		Un médico tiene registrada la información de los turnos dados en el día:
 		nombre paciente y hora de la cita (string hh:mm).
		 **el médico tiene un array de turnos
		 */
		//constructor
		public Medico(){}
		public Medico(string nombrePaciente,string horaCita){
			this.horaCita=horaCita;
			turnos=new ArrayList();
			this.nombrepac=nombrePaciente;
			pacientes=new ArrayList();
		}
		//propiedades
		//***********turnos*********
		public string Turnoss{get{return horaCita;}set{horaCita=value;}}
		public ArrayList Turnos{get{return turnos;}}
		//***********pacientes*********
		public string Pacientess{get{return nombrepac;}set{nombrepac=value;}}
		public ArrayList Pacientes{get{return pacientes;}}
		
		
		//metodos
		//****Turno****
		public  void AgregarTurno(Turno turno)		{Turnos.Add(turno);}
		public  void EliminarTurno(Turno turno)		{Turnos.Remove(turno);}
		
//		public  void TodosLosTurnos(){
//			foreach(Turno tur in turnos){
//				tur.ImprimirTurno();
//				Console.WriteLine("\n");
//			}
//		}
		public void TodaslasObraSocial(){
			ArrayList lista=new ArrayList();
			foreach (Paciente pac in pacientes) {
				lista.Add(pac.ObraSocial);
			}
			for (int i = 0; i < lista.Count; i++) {
				if(lista.Equals(pacientes)){
					Console.WriteLine(i);
				}
			}
			
		}
		public ArrayList TodosLosTurnos(){return turnos;}
		
		//****Pacientes****
		public  void AgregarPaciente(Paciente pac)	{Pacientes.Add(pac);}
		public  void EliminarPaciente(Paciente pac)	{Pacientes.Remove(pac);}
		
		public  void ModificarPaciente(string dniPaciente){
			foreach(Paciente pac in pacientes){
				if(pac.DNI==dniPaciente){
					Console.WriteLine("ingrese el nombre del Paciente: ");
					string nombre=Console.ReadLine();
					//Console.WriteLine("Ingrese el dni del Paciente: ");
					string dni=dniPaciente;
					Console.WriteLine("ingrese la obra social: ");
					string obrasocial=Console.ReadLine();
					Console.WriteLine("ingrese nro afiliado: ");
					string nroafiliado=Console.ReadLine();
					Console.WriteLine("ingrese el diagnostico: ");
					string diagnostico=Console.ReadLine();
					Paciente pacient=new Paciente(nombre,dni,obrasocial,nroafiliado,diagnostico);
					AgregarPaciente(pacient);
				}
			}
		}
		
		public ArrayList TodosLosPacientes(){return pacientes;}
		
		
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
