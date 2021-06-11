using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace CurpGenerator
{
    public partial class CurpGenerator : System.Web.UI.Page
    {
        private static string rfc = "";
        private static string curp = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Calendar1.Visible = false;

            foreach(KeyValuePair<string,string> state in states)
                DropDownStates.Items.Add(state.Value);
        }

        protected char getSecondConsonat(ref string word)
        {
            char secondConsonant = ' ';

            for(int i=1; i<word.Length; i++)
            {
                if(word[i] != 'A' && word[i] != 'E' && word[i] != 'I' && word[i] != 'O' && word[i] != 'U')
                {
                    secondConsonant = word[i];
                    break;
                }
            }

            return secondConsonant;
        }
        protected char getFirstVowel(ref string word)
        {
            char firstVowel = ' ';
            bool vowelFound = false;
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            for (int i = 1; i < word.Length; i++)
            {
                if (vowelFound) break;
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i].ToString() == vowels[j].ToString())
                    {
                        firstVowel = vowels[j];
                        vowelFound = true;
                        break;
                    }
                }
            }

            return firstVowel;
        }
        protected string getRFC(ref string firstLastName, ref string secondLastName, ref string name, ref string birthday)
        {
            string rfc = firstLastName[0].ToString()  + 
                         getFirstVowel(ref firstLastName) +
                         secondLastName[0].ToString() +
                         name[0].ToString() +
                         birthday.Substring(8, 2) + birthday.Substring(3,2) + birthday.Substring(0,2);
            return rfc;
        }
        protected void miniCalendar_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible) Calendar1.Visible = false;
            else Calendar1.Visible = true;
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtBirth.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
        }

        protected void btnSend_click(object sender, EventArgs e)
        {
            string stateKey = "";

            foreach (KeyValuePair<string, string> state in states)
                if (DropDownStates.Text == state.Value) stateKey = state.Key;
                
            string name = txtName.Text.ToUpper();
            string fLastName = txtLastName1.Text.ToUpper();
            string sLastName = txtLastName2.Text.ToUpper();
            string birth = txtBirth.Text;
            string gender = DropDownGender.Text;

            curp = getRFC(ref fLastName, ref sLastName, ref name, ref birth) +
                          gender[0].ToString() + stateKey + getSecondConsonat(ref fLastName) + getSecondConsonat(ref sLastName) + getSecondConsonat(ref name);
            rfc = getRFC(ref fLastName, ref sLastName, ref name, ref birth);
            
            labelCurp.Text = "El CURP es: " + curp;
            labelRFC.Text = "El RFC es: " + rfc;
        }

        IDictionary<string, string> states = new Dictionary<string, string>()
        {
            { "AS","Aguascalientes" },
            { "BC","Baja California Norte" },
            { "BS","Baja California Sur" },
            { "CC","Campeche" },
            { "CS","Chiapas" },
            { "CH","Chihuahua" },
            { "DF","Ciudad de México" },
            { "CL","Coahuila" },
            { "CM","Colima" },
            { "DG","Durango" },
            { "GT","Guanajuato" },
            { "GR","Guerrero" },
            { "HG","Hidalgo" },
            { "JC","Jalisco" },
            { "MC","Estado de México" },
            { "MN","Michoacán" },
            { "MS","Morelos" },
            { "NT","Nayarit" },
            { "NL","Nuevo León" },
            { "OC","Oaxaca" },
            { "PL","Puebla" },
            { "QO","Querétaro" },
            { "QR","Quintana Roo" },
            { "SP","San Luis Potosí" },
            { "SL","Sinaloa" },
            { "SR","Sonora" },
            { "TC","Tabasco" },
            { "TS","Tamaulipas" },
            { "TL","Tlaxcala" },
            { "VZ","Veracruz" },
            { "YN","Yucatán" },
            { "ZS","Zacatecas" }
        };
    }
}