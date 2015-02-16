using System;

	namespace CalculadoradeRomanos
	{
		class MainClass
		{
			public static void Main (string[] args)
			{

				int numerousuario1 = NumeroIngresadoPorElUsuario ();
				int numerousuario2 = NumeroIngresadoPorElUsuario ();
								
				if(ValidacionNumeros.ValidarNumeros(numerousuario1)== true && ValidacionNumeros.ValidarNumeros(numerousuario2)== true){
						
						
						Console.WriteLine("La suma de los numeros es: "+Sumadenumerosromanos(numerousuario1,numerousuario2));

					}
					else
					{
						Console.WriteLine("Los numeros ingresados deben ser enteros entre 0 y 9000");
					}
					
					
				}
				

				 public static int NumeroIngresadoPorElUsuario()
				{
						try
						{
							Console.WriteLine ("Ingrese un valor");
						     return  Int32.Parse(Console.ReadLine());
						}
						catch(Exception e)
						{
							return 0;
						}
				}

			    public static string Sumadenumerosromanos(int numerousuario1,int numerousuario2)
				{
					
					string SumaRoma = OperacionRomanos.ResulSumaRomano(numerousuario1,numerousuario2);
					return SumaRoma;
				}

		     
		}
	}
