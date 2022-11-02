/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 12/10/2022
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace TpFinal
{
	class NoFuncionaException :Exception{}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.ForegroundColor=ConsoleColor.Cyan;

			Console.WriteLine(
				"///////////////MENU DE OPCIONES//////////////////"+"\n"+
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
				"9) Salida"+"\n"
			);
			Medico unMedico=new Medico();
			
			int opcion;
			Console.WriteLine("Ingrese Opcion: ");
			opcion=int.Parse(Console.ReadLine());
			
			while(opcion !=(9)){
				
				
				//**************************turnos********************************************
				if(opcion==1){
					Console.WriteLine("*****Agregar Turno******"+"\n");
					Console.WriteLine("Agregar turno en formato 08:00//08:30");
					string aux1=Console.ReadLine();
					Console.WriteLine("Ingrese el nombre del paciente");
					string aux2=Console.ReadLine();
					Turno unTurno=new Turno(aux1,aux2);
				}
				if(opcion==2){
					Console.WriteLine("*****Eliminar Turno dado******");
					Console.WriteLine("Ingrese el ");
				}
				//************************listadosTurnos**************************************
				if(opcion==3){
					Console.WriteLine("******Listado de turnos dados*******");
					unMedico.TodosLosTurnos();
				}
				if(opcion==4){
					Console.WriteLine("*******Listado de obras sociales de los pacientes*******");
					unMedico.TodaslasObraSocial();
				}
				
				
				
				//**********************pacientes**********************************************
				
				if(opcion==5){
					
					Console.WriteLine("*******Agregar paciente*******");
					
					Console.WriteLine("Ingresa el nombre: ");
					string nombre=Console.ReadLine();
					Console.WriteLine("Ingresa el dni: ");
					string dni=Console.ReadLine();
					Console.WriteLine("Ingresa obraSocial: ");
					string obrasocial=Console.ReadLine();
					Console.WriteLine("Ingresa nroAfiliado: ");
					string nro=Console.ReadLine();
					Console.WriteLine("Ingresa diagnostico: ");
					string diag=Console.ReadLine();
					Paciente unPaciente=new Paciente(nombre,dni,obrasocial,nro,diag);
					unMedico.AgregarPaciente(unPaciente);
				}
				if(opcion==6){
					Console.WriteLine("*******Modificar el diagnóstico de un paciente determinado*******");
					Console.WriteLine("Ingresa el dni: ");
					string documento=Console.ReadLine();
					unMedico.ModificarPaciente(documento);
				}
				if(opcion==7){
					Console.WriteLine("*******Eliminar paciente*******");
					Console.WriteLine("ingresa el dni");
					string pacd= Console.ReadLine();
					foreach(Paciente pac in unMedico.Pacientes){
						if(pac.DNI==pacd){
							unMedico.EliminarPaciente(pac);
						}
					}
					
					Console.WriteLine("Paciente Eliminado!!");
				}
				//************************listadosTurnos************************************
				if(opcion==8){
					Console.WriteLine("*******Listado de paciente*******"+"\n");
					foreach (Paciente pac in unMedico.TodosLosPacientes()) {
						pac.ImprimirPaciente();
					}
					
				}
				
				else{
					Console.WriteLine("Ingresa numero valido");
				}
				Console.Clear();
				Console.WriteLine(
					"///////////////MENU DE OPCIONES//////////////////"+"\n"+
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
					"9) Salida"+"\n"
				);
				Console.WriteLine("Ingrese Otra Opcion: ");
				opcion=int.Parse(Console.ReadLine());
				//Console.ReadKey();
			}
			
			
			
			
			
			
			/*
			 				 
			1) Dar turno. Si no hay turnos disponibles se debe levantar
			una excepción avisando lo ocurrido (“horarios no disponibles,
			llamar próximo día de atencion”)
			
			2) Actualizar el diagnóstico de un paciente determinado.
			
			3) Cancelar un  turno dado
			
			4) Listado de turnos dados
			
			5) Listado de obras sociales de los pacientes que atiende el médico (sin repeticiones)
			
			6) Agregar paciente
			
			7) Eliminar paciente
			
			8) Listado de paciente
			
			 */
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}}
