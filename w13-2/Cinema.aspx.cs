using System;
using System.Collections.Generic;
using System.Drawing;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_2
{
    public partial class Cinema : System.Web.UI.Page
    {


        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Sala { get; set; }
        public string Biglietto { get; set; }
        public bool BigliettoRidotto { get; set; }

        public static List<Cinema> Prenotazioni { get; set; } = new List<Cinema>();
        public static List<Cinema> SalaNord { get; set; } = new List<Cinema>();
        public static List<Cinema> SalaSud { get; set; } = new List<Cinema>();
        public static List<Cinema> SalaEst { get; set; } = new List<Cinema>();
        public static List<Cinema> BigliettiRidotti { get; set; } = new List<Cinema>();
        public static List<Cinema> BigliettiRidotti2 { get; set; } = new List<Cinema>();
        public static List<Cinema> BigliettiRidotti3 { get; set; } = new List<Cinema>();

        public Cinema() { }
        public Cinema(string nome, string cognome, string sala, bool biglietto)
        {
            Nome = nome;
            Cognome = cognome;
            Sala = sala;
            BigliettoRidotto = biglietto;
        }
        public void Menu()
        {
            //Recupero valori input 
            Cinema cinema = new Cinema();
            cinema.Nome = nome.Text;
            cinema.Cognome = cognome.Text;
            string valueSala = DropDownList1.SelectedItem.Value;
            cinema.Sala = valueSala;
            if (ridotto.Checked == true)
            {
             cinema.BigliettoRidotto = true;
            }
            else
            {
                cinema.BigliettoRidotto = false;
            }

            if (cinema.Sala == "Nord")
            {
                if (SalaNord.Count >= 120)
                {
                    alertext.Text = "La sala Nord è al completo riprovare con un altra sala";
                }
                else
                {
                    Cinema cinema1 = new Cinema(nome.Text, cognome.Text,
                        DropDownList1.SelectedItem.Value,cinema.BigliettoRidotto);
                    SalaNord.Add(cinema1);
                    Prenotazioni.Add(cinema1);
                    if (cinema.BigliettoRidotto == true)
                    {
                        BigliettiRidotti.Add(cinema1);
                    }
                }
            }
            else if (cinema.Sala =="Sud")
            {
                if (SalaSud.Count >= 120)
                {
                    alertext.Text = "La sala Sud è al completo riprovare con un altra sala";
                }
                else
                {
                    Cinema cinema1 = new Cinema(nome.Text, cognome.Text,
                        DropDownList1.SelectedItem.Value, cinema.BigliettoRidotto);
                    SalaSud.Add(cinema1);
                    Prenotazioni.Add(cinema1);
                    if (cinema.BigliettoRidotto == true)
                    {
                        BigliettiRidotti2.Add(cinema1);
                    }
                }
            }
            else if (cinema.Sala == "Est")
            {
                if (SalaEst.Count >= 120)
                {
                    alertext.Text = "La sala Est è al completo riprovare con un altra sala";
                }
                else
                {

                    Cinema cinema1 = new Cinema(nome.Text, cognome.Text,
                        DropDownList1.SelectedItem.Value, cinema.BigliettoRidotto);
                    SalaEst.Add(cinema1);
                    Prenotazioni.Add(cinema1);
                    if (cinema.BigliettoRidotto == true)
                    {
                        BigliettiRidotti3.Add(cinema1);
                    }

                }
            }

            //Dettagli finali
            Dettagli.InnerHtml =
           $"<h3>Sala Nord </h3>" +
           $"<p>Numero biglietti venduti: {SalaNord.Count}  di cui {BigliettiRidotti.Count} Ridotti </p>" +
           $"<p>Numero biglietti rimanenti: {120 - SalaNord.Count} </p>"+

           $"<h3>SalaSud </h3>" +
           $"<p>Numero biglietti venduti: {SalaSud.Count}  di cui {BigliettiRidotti2.Count} Ridotti </p>" +
           $"<p>Numero biglietti rimanenti: {120 - SalaSud.Count} </p>"+

           $"<h3>Sala Est </h3>" +
           $"<p>Numero biglietti venduti: {SalaEst.Count}  di cui {BigliettiRidotti3.Count} Ridotti </p>" +
           $"<p>Numero biglietti rimanenti: {120 - SalaEst.Count} </p>";
 
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Request.Cookies["CookieLogin"] == null)
            {
               Response.Redirect("Default.aspx");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {     
           Menu();  
     
        }
    }   
}
