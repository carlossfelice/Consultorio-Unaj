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
			//private int dia, hora, minutos;
			Horario h1=new Horario(22,8,30);
			//private	string nombre,dni,obrasocial,nroafiliado,diagnostico;
			Paciente p1=new Paciente("juan","3030","pami","85","Espalda");
			//string especialidad
			Turno t1=new Turno("Huesos",h1,p1);
			//string nombremedico
			Medico m1=new Medico("carlos",t1);
			
			
			h1.ImprimirHorario();
			Console.WriteLine("***********************");
			
			p1.ImprimirPaciente();
			Console.WriteLine("***********************");
			
			t1.ImprimirTurno();
			Console.WriteLine("***********************");
			
			m1.ImprimirMedico();
			
			
			
			
			
			
			
			//inicia menu y altas o bajas
			
			
		/*	
		public void AltaTurno(Turno turno);{}
		public void BajaTurno(int numero);{}
		public void ImprimirTurno();{}
		public void ListaTurnos();{}
			
		*/	
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}