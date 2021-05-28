using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLiczniki.Dto;
using RestSharp;

namespace FormLiczniki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonWprowadz_Click(object sender, EventArgs e)
        {
            string nazwa = textBoxNazwa.Text;
            string typ = textBoxTyp.Text;
            LicznikiDto nowyLicznikDto = new LicznikiDto(null, nazwa, typ);
            
        }
        public IRestResponse<LicznikiDto> Add(LicznikiDto licznikDto)
        {
            var restClient = new RestClient(.ClientMagnumWebService);
            var request = new RestRequest($"api/Dostawy/Get/{id}", Method.GET);
            var response = restClient.Get<DayDostawyDto>(request);
            return response;
        }
    }
}
