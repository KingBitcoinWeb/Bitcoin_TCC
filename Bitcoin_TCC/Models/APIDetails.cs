using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Bitcoin_TCC.Models
{
    public class APIDetails
    {
        public string BuyValueMessage { get; set; }
        public string Buy_Value_API { get; set; }

        public string EnviaRequisicao_GET_()
        {
            Buy_Value_API = "";
            var requisicaoWeb = WebRequest.CreateHttp("https://www.mercadobitcoin.net/api/BTC/ticker/");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";

            //Coleta todos os detalhes do Mercado Bitcoin
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                string objResponse = reader.ReadToEnd();

                var xyz = JObject.Parse(objResponse);

                foreach (var item in xyz)
                {
                    try
                    {
                        Buy_Value_API = xyz.SelectToken("$.ticker.high").ToString();
                    }
                    catch
                    {
                        Console.WriteLine("Fail!");
                    }
                }

                Buy_Value_API = "R$ " + Buy_Value_API.Substring(0, 2) + "." + Buy_Value_API.Substring(2, 3) + "," + Buy_Value_API.Substring(6, 2);

                streamDados.Close();
                resposta.Close();
            }

            return Buy_Value_API;
        }
    }
}
