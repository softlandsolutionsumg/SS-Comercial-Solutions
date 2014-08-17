using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Generador_de_fechas
{
    class Fechalaborales
    {


        public string horadetrabajo(string H,string M,string S) {
            string hora = H+":"+M+":"+S+"";
            return hora;
        }
        public string horaactual() {
            string hora = "";

            DateTime Hoy = DateTime.Today;
            DateTime x=DateTime.Now; 

            hora=(x.Hour+":"+x.Minute+":"+x.Second);
          
            //2013-11-06 03:24:12
             return hora;
        }

        public string fechasiguiente()
        {
            string fechafutura = "";
            try
            {



                DateTime Hoy = DateTime.Today;
               // fechafutura = Hoy.ToString("dd-MM-yyyy");


                int india = (Convert.ToInt32(Hoy.ToString("dd")));
                int inmes = (Convert.ToInt32(Hoy.ToString("MM")));
                int inano = (Convert.ToInt32(Hoy.ToString("yyyy")));
                DateTime dateValue = new DateTime(inano, inmes, india);
                string txdia = (dateValue.ToString("dddd", new CultureInfo("es-ES")));

                if ((txdia.Equals("lunes")) || (txdia.Equals("martes")) || (txdia.Equals("miércoles")) || (txdia.Equals("jueves")))
                {
                    Console.WriteLine("L,M,M,J");
                    india++;
                }
                if (txdia.Equals("viernes")) {
                    Console.WriteLine("V");
                    int c=india+(3);
                    india = c;
                   
                }
                if (txdia.Equals("sábado"))
                {
                    Console.WriteLine("S");
                    int c = india + (2);
                    india = c;
               
                }
                if (txdia.Equals("domingo"))
                {
                    Console.WriteLine("D");
                    int c = india + (1);
                    india = c;
                  
                }


        //        Console.WriteLine("La fecha de hoy es: " + fechafutura);
          //      Console.WriteLine("LA FECHA FILTRO O: DIA: "+india+" MES: "+inmes+" ANO: "+inano);


                
                switch (inmes) {
                    case 1:
                        if (india > 31) {
                            int c= india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 2:
                        if (india > 28)
                        {
                            int c = india - 28;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 3:
                        if (india > 31)
                        {
                            int c = india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 4:
                        if (india > 30)
                        {
                            int c = india - 30;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 5:
                        if (india > 31)
                        {
                            int c = india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 6:
                        if (india > 30)
                        {
                            int c = india - 30;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 7:
                        if (india > 31)
                        {
                            int c = india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 8:
                        if (india > 31) {
                            int c= india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 9:
                        if (india > 30)
                        {
                            int c = india - 30;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 10:
                        if (india > 31)
                        {
                            int c = india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 11:
                        if (india > 30)
                        {
                            int c = india - 30;
                            india = c;
                            inmes++;
                        }
                        break;
                    case 12:
                        if (india > 31)
                        {
                            int c = india - 31;
                            india = c;
                            inmes++;
                        }
                        break;
                
                }
                
            //   Console.WriteLine("LA FECHA FILTRO A: DIA: " + india + " MES: " + inmes + " ANO: " + inano);
               if (inmes > 12) {
                   int c = inmes - 12;
                   inmes = c;
                   inano++;
               
               }
               Console.WriteLine("LA FECHA FILTRO B: DIA: " + india + " MES: " + inmes + " ANO: " + inano);
               
                //Console.WriteLine("DIA: " + india);
                //Console.WriteLine("MES: " + inmes);
                //Console.WriteLine("ANO: " + inano);
            fechafutura=inano+"-"+inmes+"-"+india;
            
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la fecha "+ex);
                fechafutura = "0110" + "-" + "00" + "-" + "00";
            
            }

          //2013-11-06 03:24:12
            
            return fechafutura;
        }
    }
}
