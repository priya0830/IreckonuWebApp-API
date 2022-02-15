using System;

namespace IreckonuWebApp_API.Classes
{
    public class Helper
    {
        public static string[] ImportFileFromDesktop(string path)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                //foreach (string line in lines)
                //{
                //    string[] columns = line.Split(',');
                //    foreach (string column in columns)
                //    {
                //        // Do something
                //    }
                //}
                return lines;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
