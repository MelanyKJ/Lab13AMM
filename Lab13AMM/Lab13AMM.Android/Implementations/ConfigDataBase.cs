using Lab13AMM.Droid.Implementations;
using Lab13AMM.Interfaces;
using System.IO;
using Xamarin.Forms;


[assembly: Dependency(typeof(ConfigDataBase))]
namespace Lab13AMM.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }


}