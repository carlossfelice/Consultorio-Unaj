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
	public class CupoTurnosLlenos:Exception
		
	{
		public string motivo;
		public CupoTurnosLlenos(string mot){motivo=mot;}
	}
	public class CupoPacientesLlenos:Exception{}
	public class Program
	{
		
		public static void Main(string[] args)
		{
			Medico unMedico=new Medico();
			Console.ForegroundColor=ConsoleColor.Cyan;
			Console.WriteLine(
				"///////////////MENU DE OPCIONES//////////////////"+"\n"+
				"1) Agregar turno"+"\n"+
				"2) Eliminar Turno"+"\n"+
				"3) Listado de turnos"+"\n"+
				"4) Listado de obras sociales"+"\n"+
				"5) Agregar paciente"+"\n"+
				"6) Modificar el diagnóstico de un paciente"+"\n"+
				"7) Eliminar paciente"+"\n"+
				"8) Listado de paciente"+"\n"+
				"9) Salida"+"\n"
			);

			int sigue=0;
			Console.WriteLine("Ingrese Opcion: ");
			try{
				sigue=int.Parse(Console.ReadLine());
			}
			catch(FormatException)
			{
				Console.WriteLine("Ingrese nuevamente un numero entero");
				sigue=0;
			}
			while(sigue!=9)
			{
				
				switch(sigue)
				{
						//**************************turnos********************************************
					case(1):
						Console.Clear();
						AgregarTurno(unMedico);
						break;
						//***************************************************************************
					case(2):
						Console.Clear();
						EliminarTurno(unMedico);
						break;
						
						//************************listadosTurnos**************************************
					case(3):
						Console.Clear();
						Console.WriteLine("******Listado de turnos dados*******");
						unMedico.listadoTurnos();
						
						break;
						//***************************************************************************
					case(4):
						Console.Clear();
						Console.WriteLine("*******Listado de obras sociales con los que trabajo*******");
						unMedico.listadoObraSocial();
						
						break;
						
						//**********************pacientes**********************************************
					case(5):
						Console.Clear();
						AgregarPaciente(unMedico);
						break;
						//***************************************************************************
					case(6):
						Console.Clear();
						ModificarPaciente(unMedico);
						
						break;
						//***************************************************************************
					case(7):
						Console.Clear();
						EliminarPaciente(unMedico);
						break;
						//***************************************************************************
					case(8):
						Console.Clear();
						Console.WriteLine("*******Listado de paciente*************");
						
						unMedico.listadoPaciente();
						
						break;

					case(9):
						sigue=9;
						break;
					default:
						
						Console.WriteLine("XXXXX Ingresa numero valido!! XXXXXX");
						break;
						
				}
				
				Console.ReadKey();
				Console.Clear();
				
				Console.WriteLine(
					"///////////////MENU DE OPCIONES//////////////////"+"\n"+
					"1) Agregar turno"+"\n"+
					"2) Eliminar Turno"+"\n"+
					"3) Listado de turnos"+"\n"+
					"4) Listado de obras sociales"+"\n"+
					"5) Agregar paciente"+"\n"+
					"6) Modificar el diagnóstico de un paciente"+"\n"+
					"7) Eliminar paciente"+"\n"+
					"8) Listado de paciente"+"\n"+
					"9) Salida"+"\n"
				);
				
				Console.WriteLine("Ingrese nuevamente Otra Opcion:1 al 9");
				
				try{
					
					sigue=int.Parse(Console.ReadLine());
					
				}
				catch(FormatException)
				{
					Console.WriteLine("Ingrese un numero entero");
				}
				
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		//********************************************************************
		public static void AgregarTurno(Medico unMedico)
		{
			Console.WriteLine("*****Agregar Turno*******************");
			unMedico.turnosDisponibles();

			Console.WriteLine("Agregar turno en formato 08:00//08:30//09:30");
			string horaTurno=Console.ReadLine();
			
			Console.WriteLine("Ingrese el nombre del paciente");
			string nombrePaciente=Console.ReadLine();
			try{
				if(unMedico.CapacidadTurnos>unMedico.ContadorOcupados)
					
					unMedico.agregarTurno(horaTurno,nombrePaciente);
				else
				{
					throw new CupoTurnosLlenos("Turnos llenos");
				}
				
			}
			catch(CupoTurnosLlenos ee){Console.WriteLine(ee.motivo);}
			
		}
		//********************************************************************
		public static void EliminarTurno(Medico unMedico)
		{
			Console.WriteLine("*****Eliminar Turno dado************");
			//no utilize el metodo eliminarTurno solo lo desocupo
			Console.WriteLine("Ingrese la hora");
			string hora=Console.ReadLine();
			Console.WriteLine("Ingrese nombre del paciente");
			string nombre=Console.ReadLine();
			
			unMedico.eliminarTurno(hora,nombre);
		}
		public static void AgregarPaciente(Medico unMedico)
		{	
			Console.WriteLine("*******Agregar paciente**************");

			Console.WriteLine("Ingresa el nombre: ");
			string nombreP=Console.ReadLine();
			Console.WriteLine("Ingresa el dni: ");
			int dniP=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresa obraSocial: ");
			string obrasocialP=Console.ReadLine();
			Console.WriteLine("Ingresa nroAfiliado: ");
			int nroP=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresa diagnostico: ");
			string diagP=Console.ReadLine();
			try
			{
				if(unMedico.CapacidadPacientes>unMedico.cantidadPacientes())
				{
					Paciente unPaciente=new Paciente(nombreP,dniP,obrasocialP,nroP,diagP);
					unMedico.agregarPaciente(unPaciente);
				}else
				{
					throw new CupoPacientesLlenos();
				}
			}catch(CupoPacientesLlenos)
			{
				Console.WriteLine("Capacidad llena");
			}
		}
		
		public static void ModificarPaciente(Medico unMedico)
		{
		Console.WriteLine("*******Modificar el diagnóstico de un paciente determinado*******");
						
						Console.WriteLine("Ingrese documento del paciente: ");
						int documento=int.Parse(Console.ReadLine());
						
						Console.WriteLine("Ingresa el diagnostico Nuevo: ");
						string diagnosticoNuevo=Console.ReadLine();
						
						unMedico.modificarDiagnostico(documento,diagnosticoNuevo);
		}
		
	
		public static void EliminarPaciente(Medico unMedico)
		
		{
		Console.WriteLine("*******Eliminar paciente***************");
						
						Console.WriteLine("Ingrese documento de paciente a eliminar: ");
						int documentoEli=int.Parse(Console.ReadLine());
						
						unMedico.eliminarPaciente(documentoEli);

						Console.WriteLine("Paciente Eliminado!!");
						
		}




		
	}

}
