using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp30
{
    class Program
    {
        public static List<Department> razporedtip(List<Department> list, string tip)
        {

            List<Department> naIme = new List<Department>();


            naIme = list.FindAll(c => c.tipDela == tip).ToList();
            return naIme;
        }
        public static double razporedurna(List<Department> list)
        {

            double d;
            List<double> naIme = new List<double>();


            foreach(var q in list)
            {
                if(q.postavka!="")
                {
                    naIme.Add(double.Parse(q.postavka, System.Globalization.CultureInfo.InvariantCulture));
                }
            }
            d = naIme.Max(a =>a);

           



            return d;
        }

        public static Department random(List<Department> list)
        {
            Department nakljucna = new Department();
            Random r = new Random();
            int i = list.Count;

            nakljucna = list[r.Next(i)];
            return nakljucna;
        }
        public static List<Department> razporedime(List<Department> list)
        {

            List<Department> naIme = new List<Department>();


            naIme = list.OrderBy(c => c.ime).ToList();
            return naIme;
        }
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\Users\Uroš\Desktop\NP2018_Podatki_Test_avgust.csv");

            List<Department> aa = new List<Department>();
            foreach (var a in lines.Skip(1))
            {
                var s = a.Split(',');

                aa.Add(new Department(s[0], s[1], s[2], s[3], s[4], s[5], s[6], s[7]));

                //if (s[5] == "Programiranje")
                //{
                //    if (s[3] != "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, 0, 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] != "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), 0));
                //    else
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, 0, 0));
                //}
                //else if (s[5] == "Proizvodnja")
                //{
                //    if (s[3] != "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), double.Parse(s[7], System.Globalization.CultureInfo.InvariantCulture)));
                //    else if (s[3] == "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, 0, 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] != "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), 0));
                //    else
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, 0, 0));
                //}
                //else if (s[5] == "Administracija")
                //{
                //    if (s[3] != "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, Convert.ToInt32(s[6]), 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, 0, 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] != "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, Convert.ToInt32(s[6]), 0));
                //    else
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, 0, 0));
                //}
                //else if (s[5] == "Strezba")
                //{
                //    if (s[3] != "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, Convert.ToInt32(s[6]), double.Parse(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, 0, double.Parse(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, Convert.ToInt32(s[6]), 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, 0, 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, 0, double.Parse(s[7])));
                //    else if (s[3] != "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, Convert.ToInt32(s[6]), 0));
                //    else
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, 0, 0));
                //}
                //else 
                //{
                //    if (s[3] != "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] == "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, Convert.ToInt32(s[6]), 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, 0, 0));
                //    else if (s[3] != "" && s[6] == "" && s[7] != "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, 0, Convert.ToDouble(s[7])));
                //    else if (s[3] != "" && s[6] != "" && s[7] == "")
                //        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, Convert.ToInt32(s[6]), 0));
                //    else
                //        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, 0, 0));
                //}


            }
            foreach (var a in aa)
                Console.WriteLine(a.postavka);
            Console.WriteLine(aa);

            List<Department> qq = new List<Department>();
            double d = razporedurna(aa);

            Department nakljucen = new Department();
            nakljucen = random(aa);

            using (StreamWriter s = new StreamWriter(@"izpis.txt", false))
            {
                XmlSerializer bla = new XmlSerializer(typeof(List<Department>));
                bla.Serialize(s, aa);
            }
            
        } 
    }
   
  
    public class Department
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public string naziv { get; set; }
        public string leto { get ; set; }
        public string emso { get; set; }
        public string tipDela { get; set; }
        public string maticna { get; set; }
        public string postavka { get; set; }


        public Department() { }
        public Department(string ime, string priimek, string naziv, string leto,string emso, string tipDela, string maticna, string postavka)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.naziv = naziv;
            this.leto = leto;
            this.emso = emso;
            this.tipDela = tipDela;
            this.maticna = maticna;
            this.postavka = postavka;
        }
    }
}
