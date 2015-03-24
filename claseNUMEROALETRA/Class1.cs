namespace claseNUMEROALETRA
{  
	/*
	   * Clase en C# para convertir n�meros a su equivalente escrito.
	   * Utilizaci�n: p�sale al m�todo p�blico "Convierte" una cadena
	   * de hasta 30 car�cteres con la representaci�n del n�mero en cifras, y la
	   * forma en la que debe actuar el n�mero, como Pronombre, o como determinante
	   * masculino o femenino, mediante un valor del enumerado Tipo, y te devolver�
	   * una cadena con el n�mero como texto.
	   *
   
	   * Ejemplo:
  
	   * Console.WriteLine(NumLetras.Convierte("12312343",NumLetras.Tipo.Pronombre));
	   *
	   * Puedes usar, modificar y distribuir libremente �ste c�digo, teniendo en cuenta
	   * que se distribuye "tal cual", sin garant�a ni responsabilidad de ning�n tipo.
	   * Si te resulta util, se agradece un link a "www.latecladeescape.com".
	   *
	   * �ste c�digo se acoge los t�rminos de la licencia descrita a continuaci�n en ingl�s
	   * y su utilizaci�n de cualquier tipo supone la aceptaci�n de dichos t�rminos.
	   *
	   * **************************************************************************
	   * Copyright � 2007 by La tecla de ESCAPE <www.latecladeescape.com>.
	   * All rights reserved.
	   *
	   * Redistribution and use in source and binary forms, with or without
	   * modification, are permitted provided that the following conditions
	   * are met:
	   * 1. Redistributions of source code must retain the above copyright
	   * notice, this list of conditions and the following disclaimer.
	   * 2. Redistributions in binary form must reproduce the above copyright
	   * notice, this list of conditions and the following disclaimer in the
	   * documentation and/or other materials provided with the distribution.
	   *
	   * THIS SOFTWARE IS PROVIDED BY THE AUTHOR AND CONTRIBUTORS ``AS IS'' AND
	   * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
	   * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
	   * ARE DISCLAIMED. IN NO EVENT SHALL THE AUTHOR OR CONTRIBUTORS BE LIABLE
	   * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
	   * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS
	   * OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
	   * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
	   * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
	   * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
	   * SUCH DAMAGE.
	   * ****************************************************************************
	   * @version 1.0
	   *
	   */
      
	using System;
	//using System.Collections.Generic;
	using System.Text;
	public class NumLetras
	{
		public enum Tipo {Pronombre, DetMasculino, DetFemenino};
		private static String[] nombresIrregulares ={
  
														"", "uno", "dos", "tres", "cuatro",
														"cinco", "seis", "siete", "ocho", "nueve",
														"diez", "once", "doce", "trece", "catorce",
														"quince", "diecis�is", "diecisiete", "dieciocho", "diecinueve",
														"veinte", "veintiuno", "veintid�s", "veintitr�s", "veinticuatro",
														"veinticinco", "veintis�is", "veintisiete", "veintiocho", "veintinueve"};
 
		private static String[] decenas={
											"","","","treinta", "cuarenta", "cincuenta",
											"sesenta", "setenta", "ochenta", "noventa"};
 
		private static String[] centenas ={
											  "", "", "doscient", "trescient","cuatrocient",
											  "quinient","seiscient","setecient","ochocient", "novecient"};
  
		private static String[] nombreMillonesSingular ={ "", "mill�n", "bill�n", "trill�n", "cuatrill�n" };
 
		private static String[] nombreMillonesPlural ={ "", "millones", "billones", "trillones", "cuatrillones" };
 
		private static String Convierte1(int i, Tipo t)
		{
			String r;

			if ( (i==1) && (t==Tipo.DetMasculino))
			{
				r="un";
			}
			else if ( (i==1) && (t==Tipo.DetFemenino))
			{
				r="una";
			}
			else
			{
				r=nombresIrregulares[i];
			}
			return r;
		}//Convierte1
 
		private static String Convierte2(int i, Tipo t)
		{
			StringBuilder r=new StringBuilder();
			if (i <= 9)
			{
				r.Append(Convierte1(i,t));
			}
			else if (i==21 && t!=Tipo.Pronombre)
			{
				if (t == Tipo.DetMasculino)
				{
					r.Append("veinti�n");
				}
				else
				{
					r.Append("veintiuna");
				}

			}
			else if (i >= 10 && i <= 29)
			{
				r.Append(nombresIrregulares[i]);
			}
			else
			{
				r.Append(decenas[i/10]);
				if (i % 10 != 0)
				{
					r.Append(" y ");
					r.Append(Convierte1(i%10, t));
				}
			}
			return r.ToString();
		}//Convierte2
		 
		private static String Convierte3(int i, Tipo t)
		{
			StringBuilder r=new StringBuilder();
			if (i <= 99)
			{
				r.Append(Convierte2(i, t));
			}
			else if (i == 100)
			{
				r.Append("cien");
			}
			else
			{
				if (i >= 101 && i <= 199)
				{
					r.Append("ciento");
				}
				else
				{
					r.Append(centenas[i / 100]);
					r.Append(t == Tipo.DetFemenino ? "as" : "os");
				}
				if (i % 100 > 0)
				{
					r.Append(" ");
					r.Append(Convierte2(i % 100, t));
				}
			}
			return r.ToString();
		} //Convierte3
		 
		private static String Convierte6(int i, Tipo t)
		{
			StringBuilder r=new StringBuilder();
			int tresPrimeros = i / 1000;
			int tresUltimos = i % 1000;
			if (tresPrimeros==1)
			{
				r.Append("mil");
			}
			else if (tresPrimeros >= 2)
			{
				if (t==Tipo.Pronombre)
					r.Append(Convierte3(tresPrimeros, Tipo.DetMasculino));
				else
					r.Append(Convierte3(tresPrimeros, t));
				r.Append(" mil");
			}
		 
			if (tresUltimos > 0)
			{
				if (tresPrimeros > 0)
				{
					r.Append(" ");
				}
				r.Append(Convierte3(tresUltimos,t));
			}
			return r.ToString();

		}
		 
		private static bool EsNumero(String s)
		{

			bool resultado = true;
			int contador=0;
			int longitud=s.Length;
			while (resultado && contador<longitud)
			{
				if (s[contador] < '0' || s[contador] > '9')
				{
					resultado = false;
				}
				contador++;
			}
			return resultado;
		}
		 
		private static String ConvierteTodo(String s, Tipo t)
		{

			StringBuilder resultado=new StringBuilder();
			int cuenta = s.Length;
			int cuentamillones = 0;
			while (cuenta > 0)
			{
				int inicio = (cuenta - 6 >= 0) ? (cuenta - 6) : 0;
				int longitud = (6 > cuenta) ? cuenta : 6;
				String stemp = s.Substring(inicio, longitud);
				int i6 = int.Parse(stemp);
				if (cuentamillones > 0 && i6>0)
				{
					if (resultado.Length > 0)
					{
						resultado.Insert(0, " ");
					}
					if (i6 > 1)
					{
						resultado.Insert(0, nombreMillonesPlural[cuentamillones]);
					}
					else
					{
						resultado.Insert(0, nombreMillonesSingular[cuentamillones]);
					}
					resultado.Insert(0, " ");
				}
				resultado.Insert(0, Convierte6(i6, t));
				if (cuentamillones == 0)
				{
					t = Tipo.DetMasculino;
				}
				cuentamillones++;
				cuenta -= 6;
			};
			return resultado.ToString();
		}

		public static String Convierte(String s, Tipo t)
		{
			String resultado="";
			s = s.Trim();
			if (s.Length > 30)
			{
				resultado = "Demasiado grande. Llego hasta 30 cifras";
			}
			else if (!EsNumero(s))
			{
				resultado = "La cadena no est� formada s�lo por n�meros";
			}
			else
			{
				resultado = ConvierteTodo(s, t);
			}
			return resultado;
		}
	}

}   