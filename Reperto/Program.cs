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
        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }
    }

    #region Constructeurs
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

    public class Annuaire
    {
        public string Nom;
        public string Prenom;
        public string Relation;

        //contructeur
        public Annuaire() { }

        public Annuaire(String paramNom, String paramPrenom, String paramRelation) {
            this.Nom = paramNom;
            this.Prenom = paramPrenom;
            this.Relation = paramRelation;
        }

    }
    #endregion

    public class GlobalFunctions
    {
        /// Retourne le chemin, depuis la racine, de l'application
        public string AppDrive()
        {
            return (AppDomain.CurrentDomain.BaseDirectory).Substring(0,3).Replace("\\", "/");
        }

        /// Retourne le chemin, depuis la racine, de l'application
        public string AppRootPath()
        {
            return (AppDomain.CurrentDomain.BaseDirectory).Replace("\\", "/");
        }

        public string selectionDatabase()
        {
            string fichier = "";
            XDocument xmlDoc = XDocument.Load(AppRootPath() + "Reperto/Configuration/AppConfig.xml");
            XElement collec = xmlDoc.Element("root").Element("fichiers");

            var records = from myTheme in collec.Elements("database") select myTheme;

            foreach (string myData in records)
            {
                fichier = myData;
            }
            return fichier;
        }

        public string selectionAnnuaire()
        {
            string fichier = "";
            XDocument xmlDoc = XDocument.Load(AppRootPath() + "Reperto/Configuration/AppConfig.xml");
            XElement collec = xmlDoc.Element("root").Element("fichiers");

            var records = from myTheme in collec.Elements("annuaire") select myTheme;

            foreach (string myData in records)
            {
                fichier = myData;
            }
            return fichier;
        }
    }

    public class FunctionFiches
    {
        GlobalFunctions gfctn = new GlobalFunctions();

        #region CRUD Fiche
            /// Creation d'une nouvelle fiche
            public string fnCreationFiche(String Cassette, String Date, String Theme, String SousTheme, String Personne, String Lieu, String Description, String LienVideo, String TempsDebutSequence)
            {
                Int32 id = 0;
                Int32 tmpId = 0;
                //### calcul de l'Id ###
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("fiches");

                var records = from myCollec in collec.Elements("myFiche")
                              orderby (int)myCollec.Element("id")
                              select myCollec;

                foreach (var myCollection in records){
                    tmpId = tmpId + 1;
                    if (myCollection.Element("id").Value != tmpId.ToString()){
                        id = tmpId;
                        break;
                    }
                }
                if (id == 0) { id = tmpId + 1; }
            

                //### enregistrement fiche ###
                xmlDoc.Element("root").Element("fiches").Add(new XElement("myFiche",
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

                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                return id.ToString();
            }

            /// Modification d'une fiche existante
            public void fnModificationFiche(Int32 nodeToUpdate, String Cassette, String Date, String Theme1, String Theme2, String Personne, String Lieu, String Description, String LienVideo, String TempsDebutSequence)
            {
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("fiches");
            
                var records = from myCollection in collec.Elements("myFiche")
                              where (int)myCollection.Element("id") == nodeToUpdate
                              select myCollection;
            
                //Remove record
                records.Remove();

                //Insert Record
                xmlDoc.Element("root").Element("fiches").Add(new XElement("myFiche",
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

                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
            }

            /// Suppression d'une fiche
            public void fnSuppressionFiche(int nodeToDelete)
            {
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("fiches");

                var records = from myCollection in collec.Elements("myFiche")
                              where (int)myCollection.Element("id") == nodeToDelete
                              select myCollection;

                //Remove record
                records.Remove();

                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
            }
        #endregion

        #region Selection Fiche
            /// Selectionner une liste de fiche en fonction des parametres de filtre
            public List<Fiche> fnSelection(string cassette, string mois, string annee, string theme1, string theme2, string personne, string lieu, string descrip)
            {
                List<Fiche> tabFiche = new List<Fiche>();
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("fiches");

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

            /// Compter le nombre de records en fonction des parametres de filtre
            public int fnCount(string cassette, string mois, string annee, string theme1, string theme2, string personne, string lieu, string descrip)
            {
                int cpt = 0;
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("fiches");

                var records = from myCollection in collec.Elements("myFiche")
                              select myCollection;

                if (cassette != string.Empty)
                {
                    records = from myCollection in records
                              where myCollection.Element("cassette").Value.ToLower().Contains(cassette.ToLower())
                              select myCollection;
                }

                if (mois != string.Empty)
                {
                    string mois2 = "";
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
                              where myCollection.Element("date").Value.Substring(3, 2) == mois2
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
                          select myCollection;


                foreach (var myData in records) { cpt = cpt + 1; }
                
                return cpt;
            }

            /// Selectionner une seule fiche en fonction de son Id
            public Fiche fnSelection(int nodeToLoad)
            {
                Fiche myFiche = new Fiche();
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("fiches");

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

        public void importData(string createdFile, string txtRechCassette, string cbxMois, string txtAnnee, string cbxTheme1, string cbxTheme2, string txtPersonne, string txtLieu, string txtMotCle)
        {
            int id = 0;
            foreach (Fiche myFiche in fnSelection(txtRechCassette, cbxMois, txtAnnee, cbxTheme1, cbxTheme2, txtPersonne, txtLieu, txtMotCle))
            {
                //### calcul de l'Id ###
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/" + createdFile);
                XElement collec = xmlDoc.Element("root").Element("fiches");

                //### enregistrement fiche ###
                xmlDoc.Element("root").Element("fiches").Add(new XElement("myFiche",
                                                                new XElement("id", id.ToString()),
                                                                new XElement("cassette", myFiche.Cassette),
                                                                new XElement("date", myFiche.Date),
                                                                new XElement("theme1", myFiche.Theme1),
                                                                new XElement("theme2", myFiche.Theme2),
                                                                new XElement("personne", myFiche.Personne),
                                                                new XElement("lieu", myFiche.Lieu),
                                                                new XElement("description", myFiche.Description),
                                                                new XElement("lienVideo", myFiche.LienVideo),
                                                                new XElement("tempsDebutSequence", myFiche.TempsDebutSequence)));

                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/" + createdFile);

                id = id + 1;
            }
        }

    }

    public class FunctionAnnuaire
    {
        GlobalFunctions gfctn = new GlobalFunctions();

        #region Selection Annuaire
        /// Selectionner une liste de fiche en fonction des parametres de filtre
        public List<Annuaire> fnSelectionAnnuaire(string nom, string prenom, string relation)
        {
            List<Annuaire> tabAnnuaire = new List<Annuaire>();
            String myDB = gfctn.selectionAnnuaire();
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Annuaires/" + myDB);
            XElement collec = xmlDoc.Element("root");

            var records = from myCollection in collec.Elements("myFiche")
                          select myCollection;

            if (nom != string.Empty)
            {
                records = from myCollection in records
                          where myCollection.Element("nom").Value.ToLower().Contains(nom.ToLower())
                          select myCollection;
            }

            if (prenom != string.Empty)
            {
                records = from myCollection in records
                          where myCollection.Element("prenom").Value.ToLower().Contains(prenom.ToLower())
                          select myCollection;
            }

            if (relation != string.Empty)
            {
                records = from myCollection in records
                          where myCollection.Element("relation").Value.ToLower().Contains(relation.ToLower())
                          select myCollection;
            }


            records = from myCollection in records
                      orderby myCollection.Element("prenom").Value
                      orderby myCollection.Element("nom").Value
                      select myCollection;



            foreach (var myData in records)
            {
                String var1 = myData.Element("nom").Value;
                String var2 = myData.Element("prenom").Value;
                String var3 = myData.Element("relation").Value;
                tabAnnuaire.Add(new Annuaire(var1, var2, var3));
            }

            return tabAnnuaire;
        }
        #endregion
    }

    public class FunctionThemes
    {
        GlobalFunctions gfctn = new GlobalFunctions();
        FunctionFiches fctn = new FunctionFiches();
        FunctionDatabaseFile fndb = new FunctionDatabaseFile();

        #region CRUD Theme
            /// Creation d'un nouveau Theme
            public void fnCreationTheme(String nomTheme)
            {
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                xmlDoc.Element("root").Element("themes").Add(new XElement("theme",
                                                             new XElement("name", nomTheme)));

                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);//
            }

            /// Modification d'un thème
            public void fnModificationTheme(string oldName, string newName)
            {
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);

                XElement themes = xmlDoc.Element("root").Element("themes");
                XElement fiches = xmlDoc.Element("root").Element("fiches");

                var records = from myTheme in themes.Elements("theme")
                              where myTheme.Element("name").Value == oldName
                              select myTheme;
                records.Remove();

                xmlDoc.Element("root").Element("themes").Add(new XElement("theme",
                           new XElement("name", newName)));

                records = from myCollec in fiches.Elements("myFiche")
                          where myCollec.Element("theme1").Value == oldName
                          select myCollec;

                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);//

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

                records = from myCollec in fiches.Elements("myFiche")
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

            /// Suppression d'un thème
            public void fnSuppressionTheme(string themeToDelete) 
            {
                //Suppression du theme dans AppConfig.xml
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement theme = xmlDoc.Element("root").Element("themes");

                var records = from myTheme in theme.Elements("theme")
                              where myTheme.Element("name").Value == themeToDelete
                              select myTheme;
                records.Remove();
                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);//
            }
        #endregion

        #region Selection Theme
            //Selection de tous les themes
            public List<string> fnSelectThemes()
            {
                List<string> listOfThemes = new List<string>();
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("root").Element("themes");

                var records = from myTheme in collec.Elements("theme")
                              orderby myTheme.Element("name").Value
                              select myTheme;

                foreach (var myData in records){
                    listOfThemes.Add(myData.Element("name").Value);
                }

                return listOfThemes;
            }

            //Vérifie que le theme passé en param n'existe pas déja
            public int fnSelectCountTheme(string theme)
            {
                int count = 0;
                String myDB = gfctn.selectionDatabase();
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/BasesDeDonnees/" + myDB);
                XElement collec = xmlDoc.Element("themes");

                var records = from myTheme in collec.Elements("theme")
                              where myTheme.Element("name").Value == theme
                              select myTheme;

                foreach (var myData in records){
                    count = count + 1;
                }
            
                return count;
            }
        #endregion

        public void importThemes(string createdFile)
        {
            foreach (string item in fnSelectThemes())
            {
                XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/" + createdFile);
                xmlDoc.Element("root").Element("themes").Add(new XElement("theme", new XElement("name", item)));
                xmlDoc.Save(gfctn.AppRootPath() + "Reperto/" + createdFile);//
            }

        }
    }

    public class FunctionMenu 
    {

        GlobalFunctions gfctn = new GlobalFunctions();

        public void saveParametreCouleur(string selectedColor)
        {
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");

            XElement couleurApp = xmlDoc.Element("root");

            var records = from myTheme in couleurApp.Elements("couleurApp").Elements("couleurSelectionnee") select myTheme;
            records.Remove();

            xmlDoc.Element("root").Element("couleurApp").Add(new XElement("couleurSelectionnee", selectedColor));

            xmlDoc.Save(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");//
        }

        public string selectionCouleur() { 
            string couleur = "Standard";
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");
            XElement collec = xmlDoc.Element("root").Element("couleurApp");

            var records = from myTheme in collec.Elements("couleurSelectionnee") select myTheme;

            foreach (string myData in records)
            {
                couleur = myData;
            }
            return couleur;
        }
    }

    public class FunctionDatabaseFile
    {
        GlobalFunctions gfctn = new GlobalFunctions();

        public void saveSelectedDatabase(string fileName)
        {
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");

            XElement couleurApp = xmlDoc.Element("root");

            var records = from myTheme in couleurApp.Elements("fichiers").Elements("database") select myTheme;
            records.Remove();

            xmlDoc.Element("root").Element("fichiers").Add(new XElement("database", fileName));

            xmlDoc.Save(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");//
        }

        public void saveSelectedAnnuaire(string fileName)
        {
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");

            XElement couleurApp = xmlDoc.Element("root");

            var records = from myTheme in couleurApp.Elements("fichiers").Elements("annuaire") select myTheme;
            records.Remove();

            xmlDoc.Element("root").Element("fichiers").Add(new XElement("annuaire", fileName));

            xmlDoc.Save(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");//
        }

        public string currentDatabase()
        {
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");
            XElement couleurApp = xmlDoc.Element("root");
            var records = from myTheme in couleurApp.Elements("fichiers").Elements("database") select myTheme;
            string toBeReturned = "";
            foreach (string myData in records){
                toBeReturned = myData;
            }
            return toBeReturned;

        }

        public string currentAnnuaire()
        {
            XDocument xmlDoc = XDocument.Load(gfctn.AppRootPath() + "Reperto/Configuration/AppConfig.xml");
            XElement couleurApp = xmlDoc.Element("root");
            var records = from myTheme in couleurApp.Elements("fichiers").Elements("annuaire") select myTheme;
            string toBeReturned = "";
            foreach (string myData in records)
            {
                toBeReturned = myData;
            }
            return toBeReturned;

        }


    }




}
