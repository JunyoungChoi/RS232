using Communication_RS232.Service;
using Communication_RS232.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Communication_RS232.Provider
{
    public class ServiceProvider
    {
        private static ServiceProvider _instance = null;
        public static ServiceProvider Instance
        {
            get
            {
                lock (typeof(ServiceProvider))
                {
                    if (_instance == null)
                    {
                        _instance = new ServiceProvider();
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// 모듈에서 사용하는 폼 라우터 리스트
        /// </summary>
        private Dictionary<string, Form> formList = new Dictionary<string, Form>()
        {
            {"FormMain", new FormMain()},
            {"FormConfig", new FormConfig()},
            {"FormJob", new FormJob()},
            {"FormTest", new FormTest()},
        };

        /// <summary>
        /// 모듈에서 사용하는 SDK 등
        /// </summary>
        ///<param string="serviceName"></param>
        ///<returns>service object return 실제 사용할 때 캐스팅해서 사용 또는 서비스가 하나라면 return 타입을 해당서비스로 작업해도 OK</returns>
        public object GetService(string serviceName)
        {
            object service = null;

            switch (serviceName.ToLower())
            {
                case "rs232":
                case "rs232c":
                    service = RS232c.Instance;
                    break;
                default:
                    service = null;
                    break;
            }

            return service;
        }

        /// <summary>
        /// 모듈에서 사용하는 Form 객체 Get
        /// </summary>
        ///<param string="formName"></param>
        ///<returns>Form</returns>
        public Form GetForm(string formName)
        {
            Form form = null;
            if (!formList.TryGetValue(formName, out form))
            {
                return null;
            }
            else
            {
                return formList[formName];
            }
        }

        private ServiceProvider()
        {

        }
    }
}
