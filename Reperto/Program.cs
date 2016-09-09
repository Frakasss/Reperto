using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Reperto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }
    }

    public class GlobalFunctions
    {
        /// <summary>
        /// Retourne le chemin, depuis la racine, de l'application
        /// </summary>
        /// <returns></returns>
        public string AppDrive()
        {
            return (AppDomain.CurrentDomain.BaseDirectory).Substring(0,3).Replace("\\", "/");
        }
        /// <summary>
        /// Retourne le chemin, depuis la racine, de l'application
        /// </summary>
        /// <returns></returns>
        public string AppRootPath()
        {
            return (AppDomain.CurrentDomain.BaseDirectory).Replace("\\", "/");
        }
        /*
        /// <summary>
        /// Retourne les "length" dernier caractères d'une chaine
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string myRight(this string value, int length)
        {
            if (String.IsNullOrEmpty(value)) return string.Empty;
            return value.Length <= length ? value : value.Substring(value.Length - length);
        }*/
    }

    public class Fiche
    {
        public string Id;
        public string Cassette;
        public string Date;
        public string Theme1;
        public string Theme2;
        public string Personne;
        public string Lieu;
        public string Description;
        public string LienVideo;
        public string TempsDebutSequence;

        //contructeur
        public Fiche() { }

        public Fiche(String paramId, String paramCassette, String paramDate, String paramTheme1, String paramTheme2, String paramPersonne, String paramLieu, String paramDescription, String paramLienVideo, String paramTempsDebutSequence)
        {
            this.Id = paramId;
            this.Cassette = paramCassette;
            this.Date = paramDate;
            this.Theme1 = paramTheme1;
            this.Theme2 = paramTheme2;
            this.Personne = paramPersonne;
            this.Lieu = paramLieu;
            this.Description = paramDescription;
            this.LienVideo = paramLienVideo;
            this.TempsDebutSequence = paramTempsDebutSequence;
        }
    }

    public class FunctionFiches
    {
        GlobalFunctions gfctn = new GlobalFunctions();

        #region CRUD
            /// <summary>
            /// Creation d'une nouvelle fiche
            /// </summary>
            /// <param name="Cassette"></param>
            /// <param name="Date"></param>
            /// <param name="Theme"></param>
            /// <param name="SousTheme"></param>
            /// <param name="Personne"></param>
            /// <param name="Description"></param>
            /// <param name="LienVideo"></param>
            /// <param name="TempsDebutSequence"></param>
            public void fnCreationFiche(String Cassette, String Date, String Theme, String SousTheme, String Personne, String Lieu, String Description, String LienVideo, String TempsDebutSequence)
            {
            
                Int32 id = 0;
                Int32 tmpId = 0;
                //### calcul de l'Id ###
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");

                var records = from myCollec in collec.Elements("myFiche")
                              orderby (int)myCollec.Element("id")
                              select myCollec;
                foreach (var myCollection in records)
                {
                    tmpId = tmpId + 1;
                    if (myCollection.Element("id").Value != tmpId.ToString())
                    {
                        id = tmpId;
                        break;
                    }
                }
                if (id == 0) { id = tmpId + 1; }
            

                //### enregistrement fiche ###
                xmlDoc.Element("root").Add(new XElement("myFiche",
                                           new XElement("id", id.ToString()),
                                           new XElement("cassette", Cassette),
                                           new XElement("date", Date),
                                           new XElement("theme1", Theme),
                                           new XElement("theme2", SousTheme),
                                           new XElement("personne", Personne),
                                           new XElement("lieu", Lieu),
                                           new XElement("description", Description),
                                           new XElement("lienVideo", LienVideo),
                                           new XElement("tempsDebutSequence", TempsDebutSequence)));

                xmlDoc.Save(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
            }

            /// <summary>
            /// Modification d'une fiche existante
            /// </summary>
            /// <param name="nodeToUpdate"></param>
            /// <param name="Cassette"></param>
            /// <param name="Date"></param>
            /// <param name="Theme"></param>
            /// <param name="SousTheme"></param>
            /// <param name="Personne"></param>
            /// <param name="Description"></param>
            /// <param name="LienVideo"></param>
            /// <param name="TempsDebutSequence"></param>
            public void fnModificationFiche(Int32 nodeToUpdate, String Cassette, String Date, String Theme1, String Theme2, String Personne, String Lieu, String Description, String LienVideo, String TempsDebutSequence)
            {
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");
            
                var records = from myCollection in collec.Elements("myFiche")
                              where (int)myCollection.Element("id") == nodeToUpdate
                              select myCollection;
            
                //Remove record
                records.Remove();

                //Insert Record
                xmlDoc.Element("root").Add(new XElement("myFiche",
                                           new XElement("id", nodeToUpdate.ToString()),
                                           new XElement("cassette", Cassette),
                                           new XElement("date", Date),
                                           new XElement("theme1", Theme1),
                                           new XElement("theme2", Theme2),
                                           new XElement("personne", Personne),
                                           new XElement("lieu", Lieu),
                                           new XElement("description", Description),
                                           new XElement("lienVideo", LienVideo),
                                           new XElement("tempsDebutSequence", TempsDebutSequence)));

                xmlDoc.Save(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
            }

            /// <summary>
            /// Suppression d'une fiche
            /// </summary>
            /// <param name="nodeToDelete"></param>
            public void fnSuppressionFiche(int nodeToDelete)
            {
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");

                var records = from myCollection in collec.Elements("myFiche")
                              where (int)myCollection.Element("id") == nodeToDelete
                              select myCollection;

                //Remove record
                records.Remove();

                xmlDoc.Save(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
            }
        #endregion

        #region Selection
            /// <summary>
            /// Selectionner une liste de fiche en fonction des parametres de filtre
            /// </summary>
            /// <returns></returns>
            public List<Fiche> fnSelection(string cassette, string mois, string annee, string theme1, string theme2, string personne, string lieu, string descrip)
            {
                List<Fiche> tabFiche = new List<Fiche>();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");

                var records = from myCollection in collec.Elements("myFiche")
                              select myCollection;

                if (cassette != string.Empty){
                    records =  from myCollection in records
                               where myCollection.Element("cassette").Value.ToLower().Contains(cassette.ToLower())
                               select myCollection;
                }

                if (mois != string.Empty){
                    string mois2="";
                    switch (mois)
                    {
                        case "Janvier": mois2 = "01"; break;
                        case "Février": mois2 = "02"; break;
                        case "Mars": mois2 = "03"; break;
                        case "Avril": mois2 = "04"; break;
                        case "Mai": mois2 = "05"; break;
                        case "Juin": mois2 = "06"; break;
                        case "Juillet": mois2 = "07"; break;
                        case "Aout": mois2 = "08"; break;
                        case "Septembre": mois2 = "09"; break;
                        case "Octobre": mois2 = "10"; break;
                        case "Novembre": mois2 = "11"; break;
                        case "Décembre": mois2 = "12"; break;
                    }
                    records = from myCollection in records
                              where myCollection.Element("date").Value.Substring(3,2) == mois2
                              select myCollection;
                }

                if (annee != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("date").Value.Substring(6, 4) == annee
                              select myCollection;
                }

                if (theme1 != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("theme1").Value == theme1 || myCollection.Element("theme2").Value == theme1
                              select myCollection;
                }

                if (theme2 != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("theme1").Value == theme2 || myCollection.Element("theme2").Value == theme2
                              select myCollection;
                }

                if (lieu != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("lieu").Value.ToLower().Replace("ç", "c").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e").Contains(lieu.ToLower().Replace("ç", "c").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e"))
                              select myCollection;
                }

                if (personne != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("personne").Value.ToLower().Replace("ç", "c").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e").Contains(personne.ToLower().Replace("ç", "c").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e"))
                              select myCollection;
                }

                if (descrip != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("description").Value.ToLower().Replace("ç", "c").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e").Contains(descrip.ToLower().Replace("ç", "c").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e"))
                              select myCollection;
                }


                records = from myCollection in records
                          orderby myCollection.Element("description").Value
                          orderby myCollection.Element("date").Value.Substring(6, 4) + myCollection.Element("date").Value.Substring(3, 2) + myCollection.Element("date").Value.Substring(0, 2)
                          select myCollection;
                


                foreach (var myData in records){
                    String var1 = myData.Element("id").Value;
                    String var2 = myData.Element("cassette").Value;
                    String var3 = myData.Element("date").Value;
                    String var4 = myData.Element("theme1").Value;
                    String var5 = myData.Element("theme2").Value;
                    String var6 = myData.Element("personne").Value;
                    String var7 = myData.Element("lieu").Value;
                    String var8 = myData.Element("description").Value;
                    String var9 = myData.Element("lienVideo").Value;
                    String var10 = myData.Element("tempsDebutSequence").Value;
                    tabFiche.Add(new Fiche(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10));
                 }

                return tabFiche;
            }

            /// <summary>
            /// Selectionner une seule fiche en fonction de son Id
            /// </summary>
            /// <param name="nodeToLoad"></param>
            /// <returns></returns>
            public Fiche fnSelection(int nodeToLoad)
            {
                Fiche myFiche = new Fiche();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");

                var records = from myCollection in collec.Elements("myFiche")
                              where (int)myCollection.Element("id") == nodeToLoad
                              select myCollection;

                foreach (var myData in records)
                {
                    myFiche.Id = myData.Element("id").Value;
                    myFiche.Cassette = myData.Element("cassette").Value;
                    myFiche.Date = myData.Element("date").Value;
                    myFiche.Theme1 = myData.Element("theme1").Value;
                    myFiche.Theme2 = myData.Element("theme2").Value;
                    myFiche.Personne = myData.Element("personne").Value;
                    myFiche.Lieu = myData.Element("lieu").Value;
                    myFiche.Description = myData.Element("description").Value;
                    myFiche.LienVideo = myData.Element("lienVideo").Value;
                    myFiche.TempsDebutSequence = myData.Element("tempsDebutSequence").Value;
                }

                return myFiche;

            }
        #endregion
    }

    public class FunctionThemes
    {
        GlobalFunctions gfctn = new GlobalFunctions();
        FunctionFiches fctn = new FunctionFiches();

        #region CRUD
            /// <summary>
            /// Creation d'un nouveau Theme
            /// </summary>
            /// <param name="nomTheme"></param>
            public void fnCreationTheme(String nomTheme)
            {
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/AppConfig.xml");
                //### enregistrement fiche ###
                xmlDoc.Element("root").Add(new XElement("theme",
                                           new XElement("name", nomTheme)));

                xmlDoc.Save(gfctn.AppRootPath() + "MyDB/AppConfig.xml");
            }

            /// <summary>
            /// Modification d'un thème
            /// </summary>
            /// <param name="oldName"></param>
            /// <param name="newName"></param>
            public void fnModificationTheme(string oldName, string newName)
            {
                //On modifie dans le fichier AppConfig.xml
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/AppConfig.xml");
                XElement theme = xmlDoc.Element("root");

                var records = from myTheme in theme.Elements("theme")
                              where myTheme.Element("name").Value == oldName
                              select myTheme;
                records.Remove();

                xmlDoc.Element("root").Add(new XElement("theme",
                           new XElement("name", newName)));

                xmlDoc.Save(gfctn.AppRootPath() + "MyDB/AppConfig.xml");


                //On modifie dans le fichier MyXmlDatabase.xml
                xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");

                records = from myCollec in collec.Elements("myFiche")
                          where myCollec.Element("theme1").Value == oldName
                          select myCollec;

                foreach (var myCollection in records)
                {
                    fctn.fnModificationFiche(Convert.ToInt32(myCollection.Element("id").Value),
                                             myCollection.Element("cassette").Value,
                                             myCollection.Element("date").Value,
                                             newName,
                                             myCollection.Element("theme2").Value,
                                             myCollection.Element("personne").Value,
                                             myCollection.Element("lieu").Value,
                                             myCollection.Element("description").Value,
                                             myCollection.Element("lienVideo").Value,
                                             myCollection.Element("tempsDebutSequence").Value);
                }

                records = from myCollec in collec.Elements("myFiche")
                          where myCollec.Element("theme2").Value == oldName
                          select myCollec;

                foreach (var myCollection in records)
                {
                    fctn.fnModificationFiche(Convert.ToInt32(myCollection.Element("id").Value),
                                             myCollection.Element("cassette").Value,
                                             myCollection.Element("date").Value,
                                             myCollection.Element("theme1").Value,
                                             newName,
                                             myCollection.Element("personne").Value,
                                             myCollection.Element("lieu").Value,
                                             myCollection.Element("description").Value,
                                             myCollection.Element("lienVideo").Value,
                                             myCollection.Element("tempsDebutSequence").Value);
                }



            }

            /// <summary>
            /// Suppression d'un thème
            /// </summary>
            /// <returns></returns>
            public void fnSuppressionTheme(string themeToDelete) 
            {
                //Suppression du theme dans AppConfig.xml
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/AppConfig.xml");
                XElement theme = xmlDoc.Element("root");

                var records = from myTheme in theme.Elements("theme")
                              where myTheme.Element("name").Value == themeToDelete
                              select myTheme;
                records.Remove();
                xmlDoc.Save(gfctn.AppRootPath() + "MyDB/AppConfig.xml");

                //remplacement du theme1 dans MyXmlDB.xml
                xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/MyXmlDB.xml");
                XElement collec = xmlDoc.Element("root");

                records = from myCollec in collec.Elements("myFiche")
                              where myCollec.Element("theme1").Value == themeToDelete
                              select myCollec;
                
                foreach (var myCollection in records)
                {
                    fctn.fnModificationFiche(Convert.ToInt32(myCollection.Element("id").Value),
                                             myCollection.Element("cassette").Value,
                                             myCollection.Element("date").Value,
                                             "",
                                             myCollection.Element("theme2").Value,
                                             myCollection.Element("personne").Value,
                                             myCollection.Element("lieu").Value,
                                             myCollection.Element("description").Value,
                                             myCollection.Element("lienVideo").Value,
                                             myCollection.Element("tempsDebutSequence").Value);
                }

                records = from myCollec in collec.Elements("myFiche")
                          where myCollec.Element("theme2").Value == themeToDelete
                          select myCollec;

                foreach (var myCollection in records)
                {
                    fctn.fnModificationFiche(Convert.ToInt32(myCollection.Element("id").Value),
                                             myCollection.Element("cassette").Value,
                                             myCollection.Element("date").Value,
                                             myCollection.Element("theme1").Value,
                                             "",
                                             myCollection.Element("personne").Value,
                                             myCollection.Element("lieu").Value,
                                             myCollection.Element("description").Value,
                                             myCollection.Element("lienVideo").Value,
                                             myCollection.Element("tempsDebutSequence").Value);
                }
            }
        #endregion

        #region Selection
        public List<string> fnSelectThemes()
        {
            List<string> listOfThemes = new List<string>();
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/AppConfig.xml");
            XElement collec = xmlDoc.Element("root");

            var records = from myTheme in collec.Elements("theme")
                          select myTheme;

            foreach (var myData in records)
            {
                listOfThemes.Add(myData.Element("name").Value);
            }

            return listOfThemes;
        }

        public int fnSelectCount(string theme)
        {
            int count = 0;
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "MyDB/AppConfig.xml");
            XElement collec = xmlDoc.Element("root");

            var records = from myTheme in collec.Elements("theme")
                          where myTheme.Element("name").Value == theme
                          select myTheme;

            foreach (var myData in records)
            {
                count = count + 1;
            }
            
            return count;
        }
        #endregion
    }


}
