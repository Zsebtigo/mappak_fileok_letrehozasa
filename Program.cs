using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;


namespace Fileok_mappak_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Milyen fileot szeretnél létrehozni?");
                Console.WriteLine("Opciók: kilépés = 0 ; mappa = 1; TXT = 2; CSV = 3; HTML = 4; CSS = 5; JS = 6;");

              
                string input = Console.ReadLine();
                int fajta;

                // Ha nem szám
                if (!int.TryParse(input, out fajta))
                {
                    Console.WriteLine("Ilyen értéket nem tudsz megadni!");
                    continue;
                }
                //mappa
                if (fajta == 1)
                {
                    Console.WriteLine("Mi legyen a mappa neve? (Kilépés: üres enter)");
                    string mappa_nev = Console.ReadLine();
                    if (!(mappa_nev == ""))
                    {
                        Directory.CreateDirectory(mappa_nev);
                    }
                    else
                    {
                        break;
                    }
                }
                //txt
                else if (fajta == 2)
                {
                    Console.WriteLine("Mi legyen a txt fájlneve? (Kilépés: üres enter)");
                    string fajl_nev = Console.ReadLine();
                    Console.WriteLine("Itt megadDhadtsz egy szövegrrészletet a txt");
                    string tartalom = Console.ReadLine();
                    if (!(fajl_nev == ""))
                    {
                        File.WriteAllText($"{fajl_nev}.txt", tartalom);
                    }
                    else
                    {
                        break;
                    }
                }
                //CSV
                else if (fajta == 3)
                {
                    Console.WriteLine("Mi legyen a CSV file neve? (Kilépés: üres enter)");
                    string csv_nev = Console.ReadLine();

                    Console.WriteLine("Add meg az adatokat (,)-vel elválasztva! \n(ha szeretnél több oszlopba is adatokat megadni akkor tegyél az adatok közé (;)-őt)");
                    string adatsor = Console.ReadLine();

                    string[] adatoka = adatsor.Split(',');
                   
                    if (!(csv_nev == ""))
                    {
  
                        File.WriteAllLines($"{csv_nev}.csv", adatoka);
                    }
                    else
                    {
                        break;
                    }
                }
                //HTML
                else if (fajta == 4)
                {
                    Console.WriteLine("Mi legyen a HTML file neve? (Kilépés: üres enter)");
                    string html_nev = Console.ReadLine();
                    Console.WriteLine("Mi legyen a weboldalad címe?");
                    string html_cim = Console.ReadLine();
                    string html_tartalom = $"<title>{html_cim}</title>";
                    if (!(html_nev == ""))
                    {
                        File.WriteAllText($"{html_nev}.html", html_tartalom);
                    }
                    else
                    {
                        break;
                    }
                }
                //CSS
                else if (fajta == 5)
                {
                    Console.WriteLine("Mi legyen a CSS file neve? (Kilépés: üres enter)");
                    string css_nev = Console.ReadLine();

                    Console.WriteLine("Milyen színű legyen a veboldalad?");
                    string szin = Console.ReadLine();

                    string css_tartalom = @"body{
    background-color:" + szin + @";
    }";
                    ;
                    if (!(css_nev == ""))
                    {
                        File.WriteAllText($"{css_nev}.css", css_tartalom);
                    }
                    else
                    {
                        break;
                    }
                }
                //JS
                else if (fajta == 6)
                {
                    Console.WriteLine("Mi legyen a JS file neve? (Kilépés: üres enter)");
                    string js_nev = Console.ReadLine();
                    string js_tartalom = "//Hallo!";
                    if (!(js_nev == ""))
                    {
                        File.WriteAllText($"{js_nev}.js", js_tartalom);
                    }
                    else
                    {
                        break;
                    }
                }
                
                else if (fajta == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ilyen opció nincs!");
                }

                //TENNIVALÓK:

                //--------------------------|
                //valami extrát kitalálni!! |
                //--------------------------|           
            
            }
            Console.ReadKey();
        }
    }
}