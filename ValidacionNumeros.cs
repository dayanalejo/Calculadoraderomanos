// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
namespace CalculadoradeRomanos
{
	public class ValidacionNumeros
	{
		public static  bool ValidarNumeros(int numero){
			bool validar = false;
			
			if(numero>0 && numero<=9999)
			{
				
				validar= true;
			}
			else
			{
				validar= false;
				
			}
			return validar;
		}
			


	}
}

