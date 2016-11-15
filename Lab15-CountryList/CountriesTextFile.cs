using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_CountryList
{
    public class CountriesTextFile
    {
        public List<string> countryList;
        public string fileLoc;

        public CountriesTextFile(List<string> countryList, string fileLoc)
        {
            CountryList = countryList;
            FileLoc = fileLoc;
        }

        #region properties
        public List<string> CountryList
        {
            get
            {
                return countryList;
            }

            set
            {
                countryList = value;
            }
        }

        public string FileLoc
        {
            get
            {
                return fileLoc;
            }

            set
            {
                fileLoc = value;
            }
        }
        #endregion

        public void CreateFile(string fileLoc)
        {
                FileLoc = "countries.txt";  
                if (File.Exists(FileLoc) == false)
            {
                CreateFile(FileLoc);
            }
        }

        public List<string> WriteToCountriesFile()
        {
            StreamWriter writer = new StreamWriter(FileLoc);
            File.WriteAllLines(FileLoc, CountryList);

            return CountryList;
        }

        public List<string> ReadFileToList()
        {
            List<string> CountryList = new List<string>();
            FileLoc = "countries.txt";

            StreamReader reader = new StreamReader(FileLoc);
            
                        
            string allCountries = reader.ReadToEnd().Trim();
            string[] countriesArray = allCountries.Split('\n'); 

            foreach (string country in countriesArray)
            {
                CountryList.Add(country);
            }

            reader.Close();
            return CountryList;
        }
        }
    }

