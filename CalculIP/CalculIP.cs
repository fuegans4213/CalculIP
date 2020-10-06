using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculIP
{
    static class CalculIP
    {
        /// <summary>
        /// Methode permettant de nettoyer un champ de Type TextBox
        /// </summary>
        /// <param name="Champ">Le champ a nettoyer</param>
        public static void NettoyageChampTXT(TextBox TB_Champ)
        {
            TB_Champ.Text = "";
        }

        /// <summary>
        /// Test de la contiguïté d'un masque de sous réseaux, exemple on ne peut pas écrire 255.254.255.0
        /// </summary>
        /// <param name="S_masque"></param>
        /// <returns></returns>
        public static bool TestMasqueContigu(string S_masque )
        {
            IPAddress masque = IPAddress.Parse(S_masque);
            byte[] masquebyte = masque.GetAddressBytes();

            if (masquebyte[0] < 255)
            {
                if (masquebyte[1] > 0 || masquebyte[2] > 0 || masquebyte[3] > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (masquebyte[1] < 255)
            {
                if (masquebyte[2] > 0 || masquebyte[3] > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (masquebyte[2] < 255)
            {
                if (masquebyte[3] > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

          }

        /// <summary>
        /// Methode permettant de calculer l'adresse réseaux en fonction d'une adresse IP + un masque de sous réseaux
        /// </summary>
        /// 
        public static string CalculAdresseReseaux(string S_adresseIP, string S_masque)
        {
            //Calcul du résultat Adresse IP
            IPAddress adresseIP = IPAddress.Parse(S_adresseIP);
            IPAddress masque = IPAddress.Parse(S_masque);

            byte[] adresseIPbyte = adresseIP.GetAddressBytes();
            byte[] masquebyte = masque.GetAddressBytes();
            byte[] res = new byte[4];

            for (int i = 0; i <= 3; i++)
            {
                //& binaire
                res[i] = (byte)(adresseIPbyte[i] & masquebyte[i]);
            }
            //Construit la chaine de retour
            string resultat = string.Join(".", res);
            return resultat;

        }

        /// <summary>
        /// Calcul de l'adresse de broadcast en fonction d'une adresse IP et d'un Masque de sous réseaux 
        /// </summary>
        /// <param name="SadresseIP"></param>
        /// <param name="Smasque"></param>
        /// <returns></returns>
        public static string CalculBroadcast(string S_adresseIP, string S_masque)
        {
            //Calcul du résultat Adresse IP
            IPAddress adresseIP = IPAddress.Parse(S_adresseIP);
            IPAddress masque = IPAddress.Parse(S_masque);

            byte[] adresseIPbyte = adresseIP.GetAddressBytes();
            byte[] masquebyte = masque.GetAddressBytes();
            byte[] res = new byte[4];

            string resultat = null;

            for (int i = 0; i <= 3; i++)
            {
                //OU binaire
                res[i] = (byte)(adresseIPbyte[i] | (masquebyte[i]) ^ 255);
            }
            //Construit la chaine de retour
            resultat = string.Join(".", res);

            return resultat;

        }

        /// <summary>
        /// Calcul d'un masque en fonction de la taille de 0 - 32
        /// </summary>
        /// <param name="Taille"></param>
        public static string CalculMasque(int I_Taille)
        {
  
            byte[] res = new byte[4];
            bool stopboucleIP = false;
            string resultat = null;
   
            //boucle permettant de construire les 4 champs IP 
            for (int i = 0; i <= 3; i++)
            {
                if (!stopboucleIP)
                {
                    //boucle allant de 7 a 0 pour calculer 2^x pour calculer le nombre decimal du masque
                    for (int bit = 7; bit > -1; bit--)
                    {
                        if (I_Taille < 1)
                        {
                            stopboucleIP = true;
                            break;
                        }
                        else
                        {
                            res[i] = (byte)(res[i] + (byte)Math.Pow(2, bit));
                            I_Taille = I_Taille - 1;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            //Construit la chaine de retour
            resultat = string.Join(".", res);

            return resultat;
        }

        /// <summary>
        /// Calcul du nombre de machines par sous réseaux 2^x-2
        /// </summary>
        /// <param name="Taille"></param>
        public static string CalculNB_MachinesParSousRéseaux(string S_masque)
        {
            IPAddress masque = IPAddress.Parse(S_masque);
            byte[] masquebyte = masque.GetAddressBytes();
            byte[] res = new byte[4];
            int NbBitsAun = 0;

            //Parcours de chaques octect (4) de l'addresse IP
            for (int i = 0; i <= 3; i++)
            {
                if (masquebyte[i] != 255)
                {
                    //invertion de bits pour le calcul du nombre de machine disponnibles. 
                    res[i] = (byte)(~masquebyte[i]);

                    //Pour chaque bit d'un octect du masque
                    for (byte bit = 1; bit <= 8; bit++)
                    {
                        //décalage binaire vers la gauche afin de déterminé avec un & le nombres de bit à 1.
                        byte test = (byte)(res[i] << bit);
                        if ((test & res[i]) == 0)
                        {
                            //Calcul du nombre de machine par octect du masque 
                            NbBitsAun += bit;
                            break;
                        }
                    }

                }

            }

            double Nbrmachines = Math.Pow(2, NbBitsAun) - 2;
            return Nbrmachines.ToString();
        }

        public static string CalculNB_NBSousRéseaux(string S_masque)
        {
            IPAddress masque = IPAddress.Parse(S_masque);
            byte[] masquebyte = masque.GetAddressBytes();
            int NbBitsAun = 0;

            //Parcours de chaques octect (4) de l'addresse IP
            for (int i = 0; i <= 3; i++)
            {
                if (masquebyte[i] != 255)
                {
                    //Pour chaque bit d'un octect du masque
                    for (byte bit = 1; bit <= 8; bit++)
                    {
                        //décalage binaire vers la gauche afin de déterminé avec un & le nombres de bit à 1.
                        byte test = (byte)(masquebyte[i] << bit);
                        if ((test & masquebyte[i]) == 0)
                        {
                            //Calcul du nombre de machine par octect du masque 
                            NbBitsAun += bit-1;
                            break;
                        }
                    }
                }
            }
            return Math.Pow(2,NbBitsAun).ToString();
        }

        //Determine le CIDR en fonction du masque renseigné par l'utilisateur
        public static string Determine_CIDR(string S_masque)
        {
            switch (S_masque)
            {
                case "255.255.255.255":
                    return "32";
                case "255.255.255.254":
                    return "31";
                case "255.255.255.252":
                    return "30";
                case "255.255.255.248":
                    return "29";
                case "255.255.255.240":
                    return "28";
                case "255.255.255.224":
                    return "27";
                case "255.255.255.192":
                    return "26";
                case "255.255.255.128":
                    return "25";
                case "255.255.255.0":
                    return "24";
                case "255.255.254.0":
                    return "23";
                case "255.255.252.0":
                    return "22";
                case "255.255.248.0":
                    return "21";
                case "255.255.240.0":
                    return "20";
                case "255.255.224.0":
                    return "19";
                case "255.255.192.0":
                    return "18";
                case "255.255.128.0":
                    return "17";
                case "255.255.0.0":
                    return "16";
                case "255.254.0.0":
                    return "15";
                case "255.252.0.0":
                    return "14";
                case "255.248.0.0":
                    return "13";
                case "255.240.0.0":
                    return "12";
                case "255.224.0.0":
                    return "11";
                case "255.192.0.0":
                    return "10";
                case "255.128.0.0":
                    return "9";
                case "255.0.0.0":
                    return "8";
                case "254.0.0.0":
                    return "7";
                case "252.0.0.0":
                    return "6";
                case "248.0.0.0":
                    return "5";
                case "240.0.0.0":
                    return "4";
                case "224.0.0.0":
                    return "3";
                case "192.0.0.0":
                    return "8";
                case "128.0.0.0":
                    return "1";
                default:
                    return null;
            }
        }

    }
}
