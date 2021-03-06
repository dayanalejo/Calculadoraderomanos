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
	public class OperacionRomanos
	{

		public static string ResulSumaRomano(int num1, int num2)
		{
			try
			{
			int Total = num1+num2;
			string romano=null;
			string[] Unidades={"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};  
			string[] Decenas={"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};  
			string[] Centenas={"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}; 
			string[] Miles={"", "M", "MM", "MMM", "IV-", "V-", "VI-", "VII-", "VII-", "IX-"};
			
			int u=Total%10;  
			int d=(Total/10)%10;  
			int c=(Total/100)%10; 
			int m=Total/1000;
			if(Total>=1000)
			{
				romano= Miles[m]+Centenas[c]+Decenas[d]+Unidades[u];
			}
			else if(Total>=100){           
				romano= Centenas[c]+Decenas[d]+Unidades[u];  
			}else{  
				if(Total>=10){  
					romano= Decenas[d]+Unidades[u];            
				}else{  
					romano= Unidades[Total];            
				}            
			}            
			
			return romano;
		} 
			catch(Exception e){

				return "La Suma no tiene representación en numeros romanos";
			} 

	} 
		

	}
}

