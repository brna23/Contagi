using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using bernabe.mattia._4j.contagi.models;
using System.Globalization;

namespace bernabe.mattia._4j.contagi
{
    class Program
    {
        static DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("en-US").DateTimeFormat;
        static ContagiRimini[] listaContagi = new ContagiRimini[350];
        static void Main(string[] args)
        {
            caricaFile();
            Console.WriteLine("Media Lunedi : {0}", calcolaMedia("Lunedi"));
            Console.WriteLine("Media Martedi : {0}", calcolaMedia("Martedi"));
            Console.WriteLine("Media Mercoledi : {0}", calcolaMedia("Mercoledi"));
            Console.WriteLine("Media Giovedi : {0}", calcolaMedia("Giovedi"));
            Console.WriteLine("Media Venerdi : {0}", calcolaMedia("Venerdi"));
            Console.WriteLine("Media Sabato : {0}", calcolaMedia("Sabato"));
            Console.WriteLine("Media Domenica : {0}", calcolaMedia("Domenica"));

            Console.ReadLine();
        }
        static void caricaFile()
        {
            StreamReader sr = new StreamReader("..//..//ContagiRimini.json");
            string file = "";
            file = sr.ReadToEnd();
            listaContagi = JsonConvert.DeserializeObject<ContagiRimini[]>(file);
        }
        static double calcolaMedia(string gg)
        {
            double somma = 0;
            double media = 0;
            int giorni = 0;

            switch (gg)
            {
                case "Lunedi":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d,dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Monday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
                case "Martedi":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d, dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Tuesday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
                case "Mercoledi":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d, dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Wednesday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
                case "Giovedi":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d, dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Thursday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
                case "Venerdi":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d, dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Friday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
                case "Sabato":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d, dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Saturday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
                case "Domenica":
                    foreach (ContagiRimini a in listaContagi)
                    {
                        if (a != null)
                        {
                            string d = a.Data;
                            DateTime dataConvert = DateTime.Parse(d, dtfi);
                            if (dataConvert.DayOfWeek == DayOfWeek.Sunday)
                            {
                                somma += a.Contagi;
                                giorni++;
                            }
                        }
                    }
                    return media = somma / giorni;
            }
            return 0;
        }
    }
}
