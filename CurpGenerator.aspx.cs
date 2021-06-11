using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        
        protected string getRFC(ref String firstLastName, ref string secondLastName, ref string name, ref string birthday)
        {
            char firstVowel = ' ';
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
            /*for(int i=0; i<firstLastName.Length; i++)
            {
                for(int j=0; j<vowels.Length; j++)
                {
                    if(firstLastName.Substring(1,1) == vowels[j])
                    {
                        firstVowel = vowels[j];
                    }
                }
            }//*/
            string rfc = firstLastName + firstVowel + secondLastName.Substring(1, 1) + secondLastName.Substring(0, 1) + name.Substring(0, 1) 
                                                        + birthday.Substring(8, 2) + birthday.Substring(3,2) + birthday.Substring(0,2);
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
            String fLastName = txtLastName1.Text.ToUpper();
            string sLastName = txtLastName2.Text.ToUpper();
            string birth = txtBirth.Text;
            char[] gender = DropDownGender.Text.ToCharArray();         
        
            curp = getRFC(ref fLastName,ref sLastName,ref name, ref birth) + gender[0] + stateKey + "NVS03";
            rfc = getRFC(ref fLastName, ref sLastName, ref name, ref birth) + "FH1";
            
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