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
            Add(nowyLicznikDto);

        }
        public IRestResponse<LicznikiDto> Add(LicznikiDto licznikDto)
        {
            var restClient = new RestClient("http://localhost:44357");
            var request = new RestRequest($"api/Liczniki/Add", Method.POST);
            request.AddJsonBody(licznikDto);
            var response = restClient.Post<LicznikiDto>(request);
            return response;
        }
    }
}
