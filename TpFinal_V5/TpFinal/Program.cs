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
			
			Console.WriteLine("Ingrese Opcion: ");
			int sigue=int.Parse(Console.ReadLine());
			
			while(sigue!=9)
			{
				switch(sigue)
				{
						//**************************turnos********************************************
					case(1):
						Console.WriteLine("*****Agregar Turno******"+"\n");
						Opcion.agregarTurnoOpcion1();
						break;
					case(2):
						Console.WriteLine("*****Eliminar Turno dado******");
						Opcion.agregarEliminarOpcion2();
						break;
						//************************listadosTurnos**************************************
					case(3):
						Console.WriteLine("******Listado de turnos dados*******");
						Opcion.agregarListadoTurnoOpcion3();
						break;
					case(4):
						Console.WriteLine("*******Listado de obras sociales de los pacientes*******");
						Opcion.agregarListadoObraSocialOpcion4();
						break;
						
						//**********************pacientes**********************************************
					case(5):
						Console.WriteLine("*******Agregar paciente*******");

						break;
					case(6):
						Console.WriteLine("*******Modificar el diagnóstico de un paciente determinado*******");
						Console.WriteLine("Ingresa el dni: ");
						
						break;
					case(7):
						Console.WriteLine("*******Eliminar paciente*******");
						Console.WriteLine("ingresa el dni");
						
						Console.WriteLine("Paciente Eliminado!!");
						break;
						//************************listadosTurnos************************************
					case(8):
						Console.WriteLine("*******Listado de paciente*******"+"\n");
						
						break;
						
					default:
						Console.WriteLine("Ingresa numero valido");
						break;
						
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
				Console.WriteLine("Ingrese nuevamente Otra Opcion: S/N");
				sigue=int.Parse(Console.ReadLine());
				
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//***********************************************************************
		//*******************metodos para resolver menu**************************
		public class ErrorException:Exception{}
		
		public static class Opcion
		{
			static Medico unMedico=new Medico();
			
			//turno
			public static void agregarTurnoOpcion1()
			{
				
				Console.Clear();
				
				Console.WriteLine("Agregar turno en formato 08:00//08:30//09:30");
				string horaTurno=Console.ReadLine();
				
				Console.WriteLine("Ingrese el nombre del paciente");
				string nombrePaciente=Console.ReadLine();
				/*
				Turno turn=new Turno(horaTurno,nombrePaciente,"Ocupado");
				unMedico.agregarTurno(turn);
				*/
				
				foreach(Turno tur in unMedico.Turnos)
				{
					if (tur.HoraTurno==horaTurno)
					{
						if (tur.EstadoTurno=="libre")
						{
							Turno turn=new Turno(horaTurno,nombrePaciente,"ocupado");
							unMedico.agregarTurno(turn);
						}
					}
					
				}
				
			}
			public static void agregarEliminarOpcion2()
			{}
			public static void agregarListadoTurnoOpcion3()
			{
				foreach(Turno tur in unMedico.Turnos ) {
					tur.ImprimirTurno();
				}
			}
			public static void agregarListadoObraSocialOpcion4()
			{
				
			}
			
			//paciente
			public static void agregarPacienteOpcion5()
			{
				Console.WriteLine("Ingresa el nombre: ");
				string nombre=Console.ReadLine();
				Console.WriteLine("Ingresa el dni: ");
				int dni=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingresa obraSocial: ");
				string obrasocial=Console.ReadLine();
				Console.WriteLine("Ingresa nroAfiliado: ");
				int nro=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingresa diagnostico: ");
				string diag=Console.ReadLine();
				Paciente unPaciente=new Paciente(nombre,dni,obrasocial,nro,diag);
			}
			public static void modificarDiagnosticoOpcion6()
			{
				int documento=int.Parse(Console.ReadLine());
				//unMedico.ModificarPaciente(documento);
			}
			public static void eliminarPacienteOpcion7()
			{
//				int pacd=int.Parse(Console.ReadLine());
//				foreach(Paciente pac in unMedico.Pacientes){
//					if(pac.DNI==pacd){
//						unMedico.EliminarPaciente(pac);
//					}
//				}
			}
			public static void listadoPacienteOpcion8()
			{
//				foreach (Paciente pac in unMedico.TodosLosPacientes()) {
//					pac.ImprimirPaciente();
//				}
			}
		}
	}
}
