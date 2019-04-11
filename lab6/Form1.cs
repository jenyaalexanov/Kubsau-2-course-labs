using lab3.Helper;
using lab6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var militaryAircraft = GetMilitaryAircraft();
            var transportAircraft = GetTransportAircraft();

            richTextBox1.Text += "MilitaryAircraft data".Append();
            richTextBox1.Text += ShowXML(militaryAircraft).Append();
            richTextBox1.Text += "TransportAircraft data".Append();
            richTextBox1.Text += ShowXML(transportAircraft);

        }

        private MilitaryAircraft GetMilitaryAircraft()
        {
            var militaryAircraft = new MilitaryAircraft()
            {
                MotorPower = 20,
                Speed = 15,
                Weight = 12000,
                ProducingCountries = new List<ProducingCountries>()
                {
                    new ProducingCountries()
                    {
                        CountryName = "Russia"
                    },
                    new ProducingCountries()
                    {
                        CountryName = "USA"
                    }
                }
            };
            return militaryAircraft;
        }

        private TransportAircraft GetTransportAircraft()
        {
            var transportAircraft = new TransportAircraft()
            {
                MotorPower = 20,
                Speed = 15,
                Weight = 12000,
                ProducingCountries = new List<ProducingCountries>()
                {
                    new ProducingCountries()
                    {
                        CountryName = "France"
                    },
                    new ProducingCountries()
                    {
                        CountryName = "USA"
                    },
                    new ProducingCountries()
                    {
                        CountryName = "Canada"
                    }
                }
            };
            return transportAircraft;
        }

        public string ShowXML(object dtoModel)
        {
            try
            {
                XmlSerializer xmlSer = new XmlSerializer(dtoModel.GetType());
                StringWriter sWriter = new StringWriter();
                xmlSer.Serialize(sWriter, dtoModel);
                return sWriter.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

    }
}
