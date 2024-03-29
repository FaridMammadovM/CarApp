﻿using Entities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace DataAccess
{
    public class DataContext
    {
        #region Properties
        public static List<Brand> Brands { get; set; }
        public static List<Model> Models { get; set; }
        public static List<AvtoSalon> AvtoSalons { get; set; }
        #endregion

        #region Constructor
        static DataContext()
        {
            Brands = new List<Brand>();
            Models = new List<Model>();
            AvtoSalons = new List<AvtoSalon>();
        }
        #endregion
        //datacontextin içindəki 3 listde sql olsaydı cədvəl yaradacaqdı amma cədvəl olmadığından 
        //aşağıdakı kodlarla database.json faylına yazdırıram.
        //aşağıda serialize edirəm lakin fayılda olanları deserialize etmeyi ehtiyaz duymadım



        /// <summary>
        /// faylın oxunması  və consola yazdırılması üçün
        /// </summary>
        /// <param name="path"></param>
        public static void StreamReader(string path)
        {            
            if (!File.Exists(path))
            {
                File.Create(path);
            }           
            string result;
            using (StreamReader srr = new StreamReader(path))
            {
                result = srr.ReadToEnd();
            }
            Extention.Print(ConsoleColor.DarkBlue, result);                     

        }
        /// <summary>
        /// listdəki məlumatları fayla yazdırmaq üçün
        /// </summary>
        /// <param name="path"></param>
        public static void StreamWriter(string path)
        {           
            string addJson = JsonConvert.SerializeObject(Brands);
            string addJson2 = JsonConvert.SerializeObject(Models);
            string addJson3 = JsonConvert.SerializeObject(AvtoSalons);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(addJson);
                sw.WriteLine(addJson2);
                sw.WriteLine(addJson3);
            }
            
        }
        /// <summary>
        /// fayıldakı məlumatların üstünə boş yazı yazıb məlumatları silmək üçün
        /// </summary>
        /// <param name="path"></param>
        public static void StreamRemove(string path)
        {
            using (StreamWriter swe = new StreamWriter(path))
            {                
                swe.WriteLine("");
            }
           
        }
    }
}
