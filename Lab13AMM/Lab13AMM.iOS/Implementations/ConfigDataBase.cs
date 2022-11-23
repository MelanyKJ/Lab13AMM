using Lab13AMM.Interfaces;
using Lab13AMM.iOS.Implementations;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab13AMM.iOS.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseFileName);
        }
    }


}