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
using System.Collections.Generic;

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
						Console.WriteLine("*****Agregar Turno*******************");
						Opcion.agregarTurnoOpcion1();
						break;
					case(2):
						Console.WriteLine("*****Eliminar Turno dado************");
						Opcion.agregarEliminarTurnoOpcion2();
						break;
						//************************listadosTurnos**************************************
					case(3):
						Console.WriteLine("******Listado de turnos dados*******");
						Opcion.agregarListadoTurnoOpcion3();
						break;
					case(4):
						Console.WriteLine("*******Listado de obras sociales con los que trabajo*******");
						Opcion.agregarListadoObraSocialOpcion4();
						break;
						
						//**********************pacientes**********************************************
					case(5):
						Console.WriteLine("*******Agregar paciente**************");
						Opcion.agregarPacienteOpcion5();
						break;
					case(6):
						Console.WriteLine("*******Modificar el diagnóstico de un paciente determinado*******");
						Opcion.modificarDiagnosticoOpcion6();
						break;
					case(7):
						Console.WriteLine("*******Eliminar paciente***************");
						Opcion.eliminarPacienteOpcion7();
						Console.WriteLine("Paciente Eliminado!!");
						break;
						//************************listadosTurnos************************************
					case(8):
						Console.WriteLine("*******Listado de paciente*************");
						Opcion.listadoPacienteOpcion8();
						break;
						
					default:
						Console.WriteLine("XXXXX Ingresa numero valido!! XXXXXX");
						break;
						
				}
				Console.ReadKey();
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
				Console.WriteLine("Ingrese nuevamente Otra Opcion:1 al 9");
				sigue=int.Parse(Console.ReadLine());
				
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//***********************************************************************
		//*******************metodos para resolver menu**************************
		public class ErrorDeSintaxis:Exception{}
		
		public static class Opcion
		{
			static Medico unMedico=new Medico();
			//podria pasar los datos por el parametro ;
			//pero preferi trabajar todo aca abajo
			//turno
			public static void agregarTurnoOpcion1()
			{
				Console.WriteLine("Turnos Disponibles :");
				foreach (Turno turnolibre in unMedico.Turnos) {
					if (turnolibre.EstadoTurno=="libre") {
						Console.WriteLine(turnolibre.HoraTurno);
					}
				}
				
				Console.WriteLine("Agregar turno en formato 08:00//08:30//09:30");
				string horaTurno=Console.ReadLine();
				
				Console.WriteLine("Ingrese el nombre del paciente");
				string nombrePaciente=Console.ReadLine();

				foreach(Turno turnoActual in unMedico.Turnos)
				{
					if (turnoActual.HoraTurno==horaTurno)
					{
						if(turnoActual.EstadoTurno=="libre")
						{
							turnoActual.EstadoTurno="ocupado";
							turnoActual.NombrePTurno=nombrePaciente;
						}
					}
				}
				
			}
			public static void agregarEliminarTurnoOpcion2()
			{
				//no utilize el metodo eliminarTurno solo lo desocupo
				Console.WriteLine("Ingrese la hora");
				string hora=Console.ReadLine();
				Console.WriteLine("Ingrese nombre del paciente");
				string nombre=Console.ReadLine();
				
				foreach (Turno TurnoDesocupar in unMedico.Turnos)
				{
					if(TurnoDesocupar.EstadoTurno=="ocupado")
					{
						TurnoDesocupar.EstadoTurno="libre";
						TurnoDesocupar.NombrePTurno=null;
					}
				}
			}
			public static void agregarListadoTurnoOpcion3()
			{
				foreach(Turno turnosLCompletos in unMedico.Turnos )
				{
					turnosLCompletos.ImprimirTurno();
				}
			}
			public static void agregarListadoObraSocialOpcion4()
			{
				ArrayList temporalObraSocial=new ArrayList();
				foreach (Paciente pacienteActual in unMedico.Pacientes)
				{
					if(!temporalObraSocial.Contains(pacienteActual.ObraSocial))
					{
						temporalObraSocial.Add(pacienteActual.ObraSocial);
					}
				}
				foreach (string obraSocialfiltrado in temporalObraSocial)
				{
					Console.WriteLine(obraSocialfiltrado);
				}
				
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
				unMedico.agregarPaciente(unPaciente);
			}
			public static void modificarDiagnosticoOpcion6()
			{
				bool estado=true;
				while(estado)
				{
					try
					{
						Console.WriteLine("Ingrese documento del paciente: ");
						int documento=int.Parse(Console.ReadLine());
						foreach (Paciente element in unMedico.Pacientes) {
							
							
							if(documento!=element.DNI)
							{
								throw new ErrorDeSintaxis();
							}
						}
						foreach (Paciente pacienteModificar in unMedico.Pacientes)
						{
							if (pacienteModificar.DNI==documento)
							{
								Console.WriteLine("Ingresa el diagnostico Nuevo: ");
								string diagnosticoNuevo=Console.ReadLine();
								pacienteModificar.Diagnostico=diagnosticoNuevo;
								estado=false;
							}
						}
					}
					catch(ErrorDeSintaxis)
					{
						Console.WriteLine("intentelo nuevamente ");
					}
				}
			}
			
			public static void eliminarPacienteOpcion7()
			{
				Console.WriteLine("Ingrese documento de paciente a eliminar: ");
				int documento=int.Parse(Console.ReadLine());
				
				foreach (Paciente pacienteEliminar in unMedico.Pacientes)
				{
					if (pacienteEliminar.DNI==documento)
					{
						unMedico.eliminarPaciente(pacienteEliminar);
					}
				}
				
			}
			
			public static void listadoPacienteOpcion8()
			{
				foreach (Paciente listaPacientes in unMedico.Pacientes) {
					listaPacientes.ImprimirPaciente();
				}
			}
		}
	}
}
