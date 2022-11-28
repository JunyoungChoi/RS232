using System.IO;
using System.Text;

namespace JY_Util
{
    public class UtilJY
    {
        private static string configMainLocation = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static bool MakeComPressBat()
        {
            string[] splitDirectory = configMainLocation.Split('\\');

            string buildMode = splitDirectory[splitDirectory.Length - 1];
            string filePath = string.Format(@"..\Compress_{0}.bat", buildMode);

            if (File.Exists(filePath))
            {
                return true;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    StringBuilder fileContents = new StringBuilder();

                    fileContents.AppendLine(@"@set YEAR=%date:~0,4%");
                    fileContents.AppendLine(@"@set MONTH=%date:~5,2%");
                    fileContents.AppendLine(@"@set DAY=%date:~8,2%");

                    fileContents.AppendLine(@"@set HOUR=%time:~0,2%");
                    fileContents.AppendLine(@"@set MINUTE=%time:~3,2%");
                    fileContents.AppendLine(@"@set SECOND=%time:~6,2%");

                    fileContents.AppendLine(@"@set POSTFIX=%YEAR%%MONTH%%DAY%_%HOUR%%MINUTE%");
                    fileContents.AppendLine(@"@set POSTFIX=%POSTFIX: =0%");

                    fileContents.AppendLine(string.Format("bandizip a -y \"{0} %POSTFIX% EXEC.zip\" {0}\\*.exe {0}\\*.pdb {0}\\*.dll {0}\\*.xml", buildMode));

                    sw.Write(fileContents.ToString());
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
