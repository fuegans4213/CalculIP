using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculIP
{
    public partial class CalculIPWindow : Form
    {

        //Expression régulière pour tester si ma chaine de caractère est bien une adresse IP 
        //Regex IP = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");
        Regex IP = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
        //Expression régulière pour tester si ma chaine de caractère est bien un masque de sous réseaux
        Regex MASQUE = new Regex(@"^(255|254|252|248|240|224|192|128|0+)\.(255|254|252|248|240|224|192|128|0+)\.(255|254|252|248|240|224|192|128|0+)\.(255|254|252|248|240|224|192|128|0+)$");

        bool ValidationAdresseIP = false;
        bool ValidationMasque = false;

        public CalculIPWindow()
        {
            InitializeComponent();
        }

        private void CalculIPWindow_Load(object sender, EventArgs e)
        {
            //Initialisation des champs
            TB_AdresseIP.Text = "192.168.51.0";
            TB_MasqueSR.Text =  "255.255.255.0";
           
        }

        #region Evennement Leave
        private void TB_AdresseIP_Leave(object sender, EventArgs e)
        {
            //Processus de vérification de la bonne conformité des champs renseignées
            if (!ValidationAdresseIP)
            {
                MessageBox.Show("L'adresse IP n'est pas valide : " + TB_AdresseIP.Text, "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TB_MasqueSR_Leave(object sender, EventArgs e)
        {
            //Processus de vérification de la bonne conformité des champs renseignées
            if (!ValidationAdresseIP || !ValidationMasque)
            {
                if (!ValidationAdresseIP && !ValidationMasque)
                {
                    MessageBox.Show("L'adresse IP et le masque de sous réseau ne sont pas valide !", "Entrées invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!ValidationMasque)
                {
                    MessageBox.Show("Le masque de sous réseau n'est pas valide : " + TB_MasqueSR.Text, "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //Calcul du résultat Adresse IP
                TB_ResultatCSR_AdresseIP.Text = CalculIP.CalculAdresseReseaux(TB_AdresseIP.Text, TB_MasqueSR.Text);
                //Calcul du résultat Broadcast 
                TB_ResultatCSR_Broadcast.Text = CalculIP.CalculBroadcast(TB_AdresseIP.Text, TB_MasqueSR.Text);
            }
        }
        #endregion

        #region Evennement TextChanged
        private void TB_AdresseIP_TextChanged(object sender, EventArgs e)
        {

            if (TB_AdresseIP.Text != "0.0.0.0")
            {
                //Test si le format de l'adresse IP est bon 
                if (IP.IsMatch(TB_AdresseIP.Text))
                {
                    TB_AdresseIP.BackColor = Color.LightGreen;
                    ValidationAdresseIP = true;
                }
                else
                {
                    TB_AdresseIP.BackColor = Color.IndianRed;
                    ValidationAdresseIP = false;
                }
            }
            else
            {
                //Pas de couleur lorsque 0.0.0.0
                TB_AdresseIP.BackColor = Color.White;
                ValidationAdresseIP = false;
            }

            //Calcul du résultat si les champs Adresse IP et Masque sont bon 
            if (ValidationAdresseIP && ValidationMasque)
            {
  
                //Calcul du résultat Adresse IP
                TB_ResultatCSR_AdresseIP.Text = CalculIP.CalculAdresseReseaux(TB_AdresseIP.Text, TB_MasqueSR.Text);
                //Calcul du résultat Broadcast 
                TB_ResultatCSR_Broadcast.Text = CalculIP.CalculBroadcast(TB_AdresseIP.Text, TB_MasqueSR.Text);
                //Calcul du nombres de machines par sous réseaux
                TB_NB_Machines.Text = CalculIP.CalculNB_MachinesParSousRéseaux(TB_MasqueSR.Text);
                //Calcul du nombres de sous réseaux
                TB_NB_SousReseaux.Text = CalculIP.CalculNB_NBSousRéseaux(TB_MasqueSR.Text);

                //Affichage du CIDR utilisé
                // TODO 
            }
            else //sinon nettoyage des champs 
            {
                CalculIP.NettoyageChampTXT(TB_ResultatCSR_AdresseIP);
                CalculIP.NettoyageChampTXT(TB_ResultatCSR_Broadcast);
                CalculIP.NettoyageChampTXT(TB_NB_Machines);
                CalculIP.NettoyageChampTXT(TB_NB_SousReseaux);
            }


        }

        private void TB_MasqueSR_TextChanged(object sender, EventArgs e)
        {
            if (TB_MasqueSR.Text != "0.0.0.0")
            {
                //Test si le format de l'adresse IP est bon 
                if (MASQUE.IsMatch(TB_MasqueSR.Text) && CalculIP.TestMasqueContigu(TB_MasqueSR.Text))
                {
                    TB_MasqueSR.BackColor = Color.LightGreen;
                    ValidationMasque = true;
                }
                else
                {
                    TB_MasqueSR.BackColor = Color.IndianRed;
                    ValidationMasque = false;
                }
            }
            else
            {
                //Pas de couleur lorsque 0.0.0.0
                TB_MasqueSR.BackColor = Color.White;
                ValidationMasque = false;
            }

            //Calcul du résultat si les champs Adresse IP et Masque sont bon 
            if (ValidationAdresseIP && ValidationMasque)
            {
                //Calcul du résultat Adresse IP
                TB_ResultatCSR_AdresseIP.Text = CalculIP.CalculAdresseReseaux(TB_AdresseIP.Text, TB_MasqueSR.Text);
                //Calcul du résultat Broadcast 
                TB_ResultatCSR_Broadcast.Text = CalculIP.CalculBroadcast(TB_AdresseIP.Text, TB_MasqueSR.Text);
                //Calcul du nombres de machines par sous réseaux
                TB_NB_Machines.Text = CalculIP.CalculNB_MachinesParSousRéseaux(TB_MasqueSR.Text);
                //Calcul du nombres de sous réseaux
                TB_NB_SousReseaux.Text = CalculIP.CalculNB_NBSousRéseaux(TB_MasqueSR.Text);

                //Determine le CIDR en se basant sur le masque 
                CombolistCIDR.SelectedIndex = CombolistCIDR.FindString(CalculIP.Determine_CIDR(TB_MasqueSR.Text));
            }
            else //sinon nettoyage des champs 
            {
                CalculIP.NettoyageChampTXT(TB_ResultatCSR_AdresseIP);
                CalculIP.NettoyageChampTXT(TB_ResultatCSR_Broadcast);
                CalculIP.NettoyageChampTXT(TB_NB_Machines);
                CalculIP.NettoyageChampTXT(TB_NB_SousReseaux);
                CalculIP.NettoyageChampTXT(TB_resultatMasque);

                //On ne sélectionne plus de valeurs
                CombolistCIDR.SelectedIndex = -1;
            }

        }
        #endregion

        private void CombolistCIDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            CombolistCIDR.BackColor = Color.FloralWhite;

            if (CombolistCIDR.SelectedItem != null)
            {
                //calcul du résultat masque
                TB_resultatMasque.Text = CalculIP.CalculMasque(Int32.Parse(CombolistCIDR.SelectedItem.ToString()));
            }
            else if (CombolistCIDR.SelectedIndex == -1)
            {
                TB_resultatMasque.Text = "";
            }
            else
            {
                MessageBox.Show("Aucunne valeur renseignée dans le champ 'Longueur du masque' ", "Entrée invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }   
}
