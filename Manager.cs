using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Web2
{
    public class HWSettings
    {
        public String DefaultPageText1 { get; set; }
    }
    public class HWManager
    {
       
        public HWManager()
        { 
        }
        public static HWSettings LoadSettings(string FilePath)
        {
            HWSettings Settings = new HWSettings();
            try
            {
                
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(HWSettings));
                System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
                Settings = (HWSettings)reader.Deserialize(file);
                file.Close();

                return Settings;


            }
            catch(Exception)
            {
                return Settings;

            }


        }
        public static void SaveSettings(string FilePath,HWSettings SettingsObj)
        {
            System.Xml.Serialization.XmlSerializer writer= new System.Xml.Serialization.XmlSerializer(typeof(HWSettings));
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HWSettings.xml");


            System.IO.FileStream file = System.IO.File.Create(fileName);
            writer.Serialize(file, SettingsObj);
            file.Close();

        }
    }
}