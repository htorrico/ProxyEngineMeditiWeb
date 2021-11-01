using Mediti2.WebConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEngineMeditiWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Clase de proxy para el wcf
                WebMeditiConector_V1Client proxy = new WebMeditiConector_V1Client();

                //Objetos a llenar que pertenecen a la aplicación
                WebPerson_V1[] applicants = null;
                WebDemographicData_V1 demographicData = new WebDemographicData_V1();
                
                demographicData.PrimaryPhone = "";
                demographicData.SecondaryPhone = "";
                



                ExtensionDataObject extensionData = null;

                //Id de la aplicación de la web
                int webApplicationID = 0;

                // Aplicación que debe llamar a los objetos de la línea 18
                WebApplication_V1 application = new WebApplication_V1
                {
                    Applicants = applicants,
                    DemographicData = demographicData,
                    ExtensionData = extensionData
                };



              var response=  proxy.SubmitWebApplication(webApplicationID, application, CalculationType_V1.None);
                Console.WriteLine(response.ErrorMessageES);
                Console.WriteLine(response.ErrorMessageEN);

                Console.Read();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
