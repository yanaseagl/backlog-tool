using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Codeplex.Data;
using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace backlogToolMain
{
    public partial class ticketForm : Form
    {
        public ticketForm()
        {
            InitializeComponent();
        }

        private void getStartBtn_Click(object sender, EventArgs e)
        {
            //string uri = HttpUtility.UrlEncode("https://yanasdev.backlog.jp/api/v2/issues?apiKey=OqjsvIhO6jtqk8Z4AhGNJetQYHqk04yJzp0mueTIiwnhdGebPDRQJcYZmVu6obg0&statusId[]=1");
            var req = WebRequest.Create("https://yanasdev.backlog.jp/api/v2/issues?apiKey=OqjsvIhO6jtqk8Z4AhGNJetQYHqk04yJzp0mueTIiwnhdGebPDRQJcYZmVu6obg0&statusId[]=1");
            HttpClient client = new HttpClient();
            var res = req.GetResponse();
            var resStream = res.GetResponseStream();
            //var serializer = new DataContractJsonSerializer(typeof(ServiceResult));
            //var param = new Hashtable();
            //string baseUri = "https://" + spaceTBox.Text + ".backlog.jp/";
            //string apiBaseUrl = baseUri + "api/v2/";
            //string getTicketApi = apiBaseUrl + "issues";
            //param["apiKey"] = apikeyTBox.Text;
            ////string apiUrl = getTicketApi + "?" + apikeyTBox.Text;
            //var serializer = new JavaScriptSerializer();
            //var json = serializer.Serialize(param);
            //var content = new StringContent(json);
            ////client.BaseAddress = new Uri(baseUri);
            ////client.DefaultRequestHeaders.Accept.Clear();
            var response = client.GetStringAsync("https://yanasdev.backlog.jp/api/v2/issues?apiKey=OqjsvIhO6jtqk8Z4AhGNJetQYHqk04yJzp0mueTIiwnhdGebPDRQJcYZmVu6obg0&statusId[]=1").Result;
            //var json = serializer.Serialize(response);
            //string json = JsonConvert.SerializeObject(response, Formatting.Indented);
            var obj = JsonConvert.DeserializeObject<Person>("resStream");
            Console.WriteLine("id: {0}, issueKey: {1}", obj.id, obj.issueKey);
            //response.EnsureSuccessStatusCode();
            label2.Text = obj.ToString();
            //var json1 = DynamicJson.Parse(json);
            //var test = json1.id;
            //label2.Text = response.ToString();

            //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = client.GetAsync("api/v2/issues").Result;
            //if(response.IsSuccessStatusCode)
            //{
            //    var product = response.Content.ReadAsStreamAsync().Result;
            //    label2.Text = product.ToString();
            //}
        }
    }
}
