using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_CountryList
{
    protected class Validator : CountriesTextFile
    {

        public Validator(List<string> countryList, string fileLoc) : base(countryList, fileLoc)
        {
            public static void ValidateFilePresence()
        {

            datafile = CreateFile(FileLoc);

        }
    }
}