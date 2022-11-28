using Communication_RS232.Constants;
using Communication_RS232.Entity;
using ISSOFT.Util;
using System;
using System.IO;

namespace Communication_RS232.Repository
{
    class ConfigRepository
    {
        private static ConfigRepository _instance = null;
        public static ConfigRepository Instance
        {
            get
            {
                lock (typeof(ConfigRepository))
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigRepository();
                    }
                    return _instance;
                }
            }
        }

        private Ini iniConfig;

        private ConfigRepository()
        {
            string dir = Path.Combine(ServiceConstants.ConfigMainLocation, "Config");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            iniConfig = new Ini(Path.Combine(dir, "Config.ini"));

            load();
        }

        public Config Config = new Config();

        public event EventHandler OnUpdateConfig;

        public void SetConfig(Config config)
        {
            this.Config = config;

            OnUpdateConfigEvent();
        }

        public Config GetConfig()
        {
            return Config;
        }


        private void OnUpdateConfigEvent()
        {
            OnUpdateConfig?.Invoke(this, EventArgs.Empty);
        }

        public bool Save()
        {
            string sectionName = "RS232";

            iniConfig.IniWriteValue(sectionName, "Port Name", Config.IOInfoRS232.Portname);
            iniConfig.IniWriteValue(sectionName, "Baud Rate", Config.IOInfoRS232.BaudRate.ToString());
            iniConfig.IniWriteValue(sectionName, "Parity", Config.IOInfoRS232.Parity.ToString());
            iniConfig.IniWriteValue(sectionName, "Data Bit", Config.IOInfoRS232.DataBit.ToString());
            iniConfig.IniWriteValue(sectionName, "Stop Bits", Config.IOInfoRS232.StopBits.ToString());
            iniConfig.IniWriteValue(sectionName, "HandShake", Config.IOInfoRS232.HandShake.ToString());

            return true;
        }

        private bool load()
        {
            string sectionName = "RS232";

            Config config = new Config();

            config.IOInfoRS232.Portname = iniConfig.IniReadValue(sectionName, "Port Name");

            if (!int.TryParse(iniConfig.IniReadValue(sectionName, "Baud Rate"), out config.IOInfoRS232.BaudRate))
            {
                config.IOInfoRS232.BaudRate = 9600;
            }

            if (!Enum.TryParse(iniConfig.IniReadValue(sectionName, "Parity"), out config.IOInfoRS232.Parity))
            {
                config.IOInfoRS232.Parity = System.IO.Ports.Parity.None;
            }

            if (!int.TryParse(iniConfig.IniReadValue(sectionName, "Data Bit"), out config.IOInfoRS232.DataBit))
            {
                config.IOInfoRS232.DataBit = 8;
            }

            if (!Enum.TryParse(iniConfig.IniReadValue(sectionName, "Stop Bits"), out config.IOInfoRS232.StopBits))
            {
                config.IOInfoRS232.StopBits = System.IO.Ports.StopBits.None;
            }

            if (!Enum.TryParse(iniConfig.IniReadValue(sectionName, "HandShanke"), out config.IOInfoRS232.HandShake))
            {
                config.IOInfoRS232.HandShake = System.IO.Ports.Handshake.None;
            }

            SetConfig(config);

            return true;
        }
    }
}
