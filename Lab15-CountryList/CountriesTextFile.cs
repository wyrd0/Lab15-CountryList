using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_CountryList
{
    class CountriesTextFile
    {
        private List<string> countryList;
        private string fileLoc;

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

        public void CreateFile()
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

        }

        public List<string> ReadFileToList()
        {
            List<string> CountryList = new List<string>();
            this.FileLoc = "countries.txt";

            StreamReader reader = new StreamReader(this.FileLoc);
            
                        
            string allCountries = reader.ReadToEnd().Trim();
            string[] countriesArray = allCountries.Split('\n'); 

            foreach (string country in countriesArray)
            {
                CountryList.Add(country);
            }

            reader.Close();
            return CountryList;
        }

        private object CreateFile(string fileLoc)
        {
            throw new NotImplementedException();
        }
    }
}
