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
	class Program
	{
		public static void Main(string[] args)
		{

			int opcion =0;
			Paciente p1=new Paciente();
			Turno t1=new Turno();
			do{
				Console.Clear();
				
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
					"**************salida****************"+"\n"+
					"9) Salir aplicacion"+"\n"
				);
				
				Console.WriteLine("Ingrese Una Opcion: ");
				opcion=Convert.ToInt32( Console.ReadLine());
				
				switch(opcion)
				{
//						Paciente pacient=new Paciente();
//						Turno turn=new Turno();
						
						//**************************turnos********************************************
					case 1:
						Console.WriteLine(
							"*****Agregar Turno******"+"\n"+
							"Agregar turno en formato 08:00//08:30"
						);
						string aux1=Console.ReadLine();
						Console.WriteLine("Ingrese el nombre del paciente");
						string aux2=Console.ReadLine();
						Turno turn=new Turno(aux1,aux2);
						Medico.AgregarTurno(turn);
						turn.ImprimirTurno();
						break;
						
					case 2:
						Console.WriteLine("*****Eliminar Turno dado******");
						Console.WriteLine("Ingrese el ");
						break;
						//************************listadosTurnos**************************************
					case 3:
						Console.WriteLine("******Listado de turnos dados*******");
						Medico.TodosLosTurnos();
						break;
					case 4:
						Console.WriteLine("*******Listado de obras sociales de los pacientes*******");
						break;
						//**********************pacientes**********************************************
					case 5:
						Console.WriteLine("*******Agregar paciente*******");
						
						break;
					case 6:
						Console.WriteLine("*******Modificar el diagnóstico de un paciente determinado*******");
						break;
					case 7:
						Console.WriteLine("*******Eliminar paciente*******");
						break;
						//************************listadosTurnos************************************
					case 8:
						Console.WriteLine("*******Listado de paciente*******");
						break;
						//************************Salida*********************************************
					case 9:
						Console.WriteLine("Saliendo de la aplicacion... ");
						break;
					default:
						Console.WriteLine("Ingresa un numero valido");
						break;
				}
				Console.ReadKey();
			}
			while(opcion !=9);
			
			
			
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
	}
}