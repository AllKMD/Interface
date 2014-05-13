using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Interface.Komentarze;
using System.IO;

using Interface.Modules.MojaSprzedaz.KontrolkiWystawienia;
using Interface._Classes;
using Interface.webapi; 
using Interface;

namespace Interface.MojaSprzedaz
{
    public partial class wystawianieUserControl : UserControl
    {
        
        AllegroWebApiService allegroService = new AllegroWebApiService();
        Categories cat;
        bool warunek = false;

        private List<int> listNamesDynamicControls; //Lista nazw parametrow (nazwy to ID danego pola(parametru) z formularza)
        const string webAPIKey = "7dda4ce4";
        int categoryId;
        int x,y;    // Zmienne globalne dotyczace Lokalizacji obiektów które są tworzone dynamiczne x - Width | y - Height 
        //==================================================================================================================================//
        // METODY Do Tworzenia Parametru "Nazwa Przedmiotu"  i Kategoria   =================================================================//
        public void CreateNameAuctionControl(Categories cat, List<int> listNameDynamicControls, out List<int> tempList)
        {
            //Tworzy sie Kontrolka z polem "Nazwa Przedmiotu"
            NameAuctionControl nameAuctionControl = new NameAuctionControl(cat.SELLFORMFIELDS, 0);
            nameAuctionControl.Location = new Point(10, 20);
            nazwaIKategoriaGroupBox.Controls.Add(nameAuctionControl);
            
            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDS[0].sellformid);
            tempList = listNameDynamicControls;
        }       
        public void CreateKategoriaAuctionControl(Categories cat, List<int> listNameDynamicControls, out List<int> tempList)
        {
            //Tworzy sie category1Label
            var category1Label = new Label();
            category1Label.Text = cat.SELLFORMFIELDS[1].sellformtitle;
            category1Label.Name = cat.SELLFORMFIELDS[1].sellformtitle + "Label";
            category1Label.Location = new Point(20, 75);
            nazwaIKategoriaGroupBox.Controls.Add(category1Label);

            //Dodaje Liste kategori do category1ComboBox, ustawia go w odpowiednim miejscu i dodaje do nazwaIKategoriaGroupBox (w topPanel)
            category1ComboBox.Items.AddRange(cat.TEMPCATSARRAY); 
            category1ComboBox.Location = new Point(150, 75);
            nazwaIKategoriaGroupBox.Controls.Add(category1ComboBox);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDS[1].sellformid);
            tempList = listNameDynamicControls;
        }



        //==================================================================================================================================//
        //Metoda Główna=====================================================================================================================//
        public wystawianieUserControl(Categories cat)
        {
            InitializeComponent();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to exit.");
            Console.Read();
            this.cat = cat;                                                             // Przypisanie wartości z parametru do zmiennej lokalnej 
            listNamesDynamicControls = new List<int>();                                 // Tworzenie pustej Listy parametrow
            //==============================================================================================================================//
            //==Tworza się "Nazwa Przedmiotu" -Label -TextBox  I "Kategoria" -Label -ComboBox ==============================================//
            CreateNameAuctionControl(cat, listNamesDynamicControls, out listNamesDynamicControls);
            CreateKategoriaAuctionControl(cat, listNamesDynamicControls, out listNamesDynamicControls);
            //==============================================================================================================================//

        }

        // Usuwanie kontrolek w danej kontrolce (nazwa to parametr kontrolki Z Której Usuwamy)
        public void DeleteControls(string nazwa)
        {
            string temp = parametryGroupBox.Name;
            parametryGroupBox.Name = nazwa;
            for (int j = 0; j < parametryGroupBox.Controls.Count * 6; j++)
            {
                for (int i = 1; i < parametryGroupBox.Controls.Count; i++)
                {
                    Control ctrl = parametryGroupBox.Controls[i];
                    parametryGroupBox.Controls.Remove(ctrl);
                    ctrl.Dispose();
                    parametryGroupBox.Refresh();
                    parametryGroupBox.Visible = false;
                }
            }
            parametryGroupBox.Name = temp;
        }

        public void category1Zdarzenia(Categories cat,bool warunek,string[] childrenCatNames)
        {
            if (warunek == true)
            {
                category2ComboBox.Text = "";
                category2ComboBox.Items.Clear();
                category2ComboBox.Items.AddRange(childrenCatNames);
                category2ComboBox.Visible = true;
                category2ComboBox.Location = new Point(425, 75);

                //Czyszczenie i Ukrywanie kolejnych categoryComboBoxow
                category3ComboBox.Text = "";
                category3ComboBox.Visible = false;
                category4ComboBox.Text = "";
                category4ComboBox.Visible = false;
                category5ComboBox.Text = "";
                category5ComboBox.Visible = false;
                category6ComboBox.Text = "";
                category6ComboBox.Visible = false;

                formaSprzedazyComboBox.Text = "";
                formaSprzedazyComboBox.Items.Clear();

                midPanel.Visible = false;
                confirmCategoryButton.Visible = false;
                parametrySzczegolowWMidTopPanelGroupBox.Visible = false;
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Visible = false;
            }
            else
            {
                categoryId = cat.getCatId(category1ComboBox.Text);
                cat.SELLFORMFIELDSFORCATEGORY = allegroService.doGetSellFormFieldsForCategory(webAPIKey, 1, categoryId);

                category2ComboBox.Visible = false;
                category3ComboBox.Visible = false;
                category4ComboBox.Visible = false;
                category5ComboBox.Visible = false;
                category6ComboBox.Visible = false;
                midPanel.Visible = false;

                confirmCategoryButton.Location = new Point(169, 115);
                confirmCategoryButton.Visible = true;
                nazwaIKategoriaGroupBox.Controls.Add(confirmCategoryButton);
 
            }

        }
        //klikniecie na category1ComboBox
        private void category1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteControls(parametryGroupBox.Name);
            DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
            DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
            string[] childrenCatNames = cat.getChildrenNames(cat.getCatId(category1ComboBox.Text)); //Pobieranie id kategori z category1ComboBox
            int liczbaElementow = childrenCatNames.Count(); //Przypisanie liczby elementow danej kategori
            if (liczbaElementow != 0)                       //Jesli jest różne bedziemy pobierać nowe kategorie do category2ComboBox
            {
                warunek = true;
                // Usuwanie kontrolek z Parametrów
                category1Zdarzenia(cat,warunek, childrenCatNames);
            }
            else
            {
                warunek = false;
                category1Zdarzenia(cat, warunek, childrenCatNames);
            }
        }

        public void category2Zdarzenia(Categories cat, bool warunek, string[] childrenCatNames)
        {
            if (warunek == true)
            {
                category3ComboBox.Text = "";
                category3ComboBox.Items.Clear();
                category3ComboBox.Items.AddRange(childrenCatNames);
                category3ComboBox.Visible = true;
                category3ComboBox.Location = new Point(582, 75);
                //Czyszczenie i Ukrywanie kolejnych categoryComboBoxow
                category4ComboBox.Text = "";
                category4ComboBox.Visible = false;
                category5ComboBox.Text = "";
                category5ComboBox.Visible = false;
                category6ComboBox.Text = "";
                category6ComboBox.Visible = false;

                formaSprzedazyComboBox.Text = "";
                formaSprzedazyComboBox.Items.Clear();

                midPanel.Visible = false;
                confirmCategoryButton.Visible = false;
                parametrySzczegolowWMidTopPanelGroupBox.Visible = false;
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Visible = false;
            }
            else
            {
                categoryId = cat.getCatId(category2ComboBox.Text);
                cat.SELLFORMFIELDSFORCATEGORY = allegroService.doGetSellFormFieldsForCategory(webAPIKey, 1, categoryId);
                category3ComboBox.Visible = false;
                category4ComboBox.Visible = false;
                category5ComboBox.Visible = false;
                category6ComboBox.Visible = false;

                midPanel.Visible = false;
                confirmCategoryButton.Location = new Point(425, 105);
                confirmCategoryButton.Visible = true;
                nazwaIKategoriaGroupBox.Controls.Add(confirmCategoryButton);

            }

        }
        //klikniecie na category2ComboBox
        private void category2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteControls(parametryGroupBox.Name);
            DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
            DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
            string[] childrenCatNames = cat.getChildrenNames(cat.getCatId(category2ComboBox.Text));
            int ile = childrenCatNames.Count();
            warunek = false;
            if (ile != 0)
            {
                warunek = true;
                category2Zdarzenia(cat, warunek, childrenCatNames);
            }
            else
            {
                warunek = false;
                category2Zdarzenia(cat, warunek, childrenCatNames);

            }
        }

        public void category3Zdarzenia(Categories cat, bool warunek, string[] childrenCatNames)
        {
            if (warunek == true)
            {
                category4ComboBox.Text = "";
                category4ComboBox.Items.Clear();
                category4ComboBox.Items.AddRange(childrenCatNames);
                category4ComboBox.Visible = true;
                category4ComboBox.Location = new Point(730, 75);
                //Czyszczenie i Ukrywanie kolejnych categoryComboBoxow
                category5ComboBox.Text = "";
                category5ComboBox.Visible = false;
                category6ComboBox.Text = "";
                category6ComboBox.Visible = false;

                formaSprzedazyComboBox.Text = "";
                formaSprzedazyComboBox.Items.Clear();

                midPanel.Visible = false;
                confirmCategoryButton.Visible = false;
                parametrySzczegolowWMidTopPanelGroupBox.Visible = false;
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Visible = false;
            }
            else
            {
                categoryId = cat.getCatId(category3ComboBox.Text);
                cat.SELLFORMFIELDSFORCATEGORY = allegroService.doGetSellFormFieldsForCategory(webAPIKey, 1, categoryId);
                category4ComboBox.Visible = false;
                category5ComboBox.Visible = false;
                category6ComboBox.Visible = false;

                midPanel.Visible = false;
                confirmCategoryButton.Location = new Point(582, 105);
                confirmCategoryButton.Visible = true;
                nazwaIKategoriaGroupBox.Controls.Add(confirmCategoryButton);

            }

        }
        //klikniecie na category3ComboBox
        private void category3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteControls(parametryGroupBox.Name);
            DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
            DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
            string[] childrenCatNames = cat.getChildrenNames(cat.getCatId(category3ComboBox.Text));
            int ile = childrenCatNames.Count();
            warunek = false;
            if (ile != 0)
            {
                warunek = true;
                category3Zdarzenia(cat, warunek, childrenCatNames);
            }
            else
            {
                warunek = false;
                category3Zdarzenia(cat, warunek, childrenCatNames);

            }
        }

        public void category4Zdarzenia(Categories cat, bool warunek, string[] childrenCatNames)
        {
            if (warunek == true)
            {
                category5ComboBox.Text = "";
                category5ComboBox.Items.Clear();
                category5ComboBox.Items.AddRange(childrenCatNames);
                category5ComboBox.Visible = true;
                category5ComboBox.Location = new Point(883, 75);
                //Czyszczenie i Ukrywanie kolejnych categoryComboBoxow
                category6ComboBox.Text = "";
                category6ComboBox.Visible = false;

                formaSprzedazyComboBox.Text = "";
                formaSprzedazyComboBox.Items.Clear();

                midPanel.Visible = false;
                confirmCategoryButton.Visible = false;
                parametrySzczegolowWMidTopPanelGroupBox.Visible = false;
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Visible = false;
            }
            else
            {
                categoryId = cat.getCatId(category4ComboBox.Text);
                cat.SELLFORMFIELDSFORCATEGORY = allegroService.doGetSellFormFieldsForCategory(webAPIKey, 1, categoryId);
                category5ComboBox.Visible = false;
                category6ComboBox.Visible = false;

                midPanel.Visible = false;
                confirmCategoryButton.Location = new Point(730, 105);
                confirmCategoryButton.Visible = true;
                nazwaIKategoriaGroupBox.Controls.Add(confirmCategoryButton);
            }
        }
        //klikniecie na category4ComboBox
        private void category4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] childrenCatNames = cat.getChildrenNames(cat.getCatId(category4ComboBox.Text));
            int ile = childrenCatNames.Count();
            warunek = false;
            if (ile != 0)
            {
                warunek = true;
                category4Zdarzenia(cat, warunek, childrenCatNames);
                DeleteControls(parametryGroupBox.Name);
                DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
                DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);

            }
            else
            {
                warunek = false;
                category4Zdarzenia(cat, warunek, childrenCatNames);

            }
        }

        public void category5Zdarzenia(Categories cat, bool warunek, string[] childrenCatNames)
        {
            if (warunek == true)
            {
                category6ComboBox.Text = "";
                category6ComboBox.Items.Clear();
                category6ComboBox.Items.AddRange(childrenCatNames);
                category6ComboBox.Visible = true;
                category6ComboBox.Location = new Point(1036, 75);
                //Czyszczenie i Ukrywanie kolejnych categoryComboBoxow
                            //brak

                formaSprzedazyComboBox.Text = "";
                formaSprzedazyComboBox.Items.Clear();

                midPanel.Visible = false;
                confirmCategoryButton.Visible = false;
                parametrySzczegolowWMidTopPanelGroupBox.Visible = false;
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Visible = false;
            }
            else
            {
                categoryId = cat.getCatId(category5ComboBox.Text);
                cat.SELLFORMFIELDSFORCATEGORY = allegroService.doGetSellFormFieldsForCategory(webAPIKey, 1, categoryId);
                category6ComboBox.Visible = false;

                midPanel.Visible = false;
                confirmCategoryButton.Location = new Point(883, 105);
                confirmCategoryButton.Visible = true;
                nazwaIKategoriaGroupBox.Controls.Add(confirmCategoryButton);
            }
        }
        //klikniecie na category5ComboBox
        private void category5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] childrenCatNames = cat.getChildrenNames(cat.getCatId(category5ComboBox.Text));
            int ile = childrenCatNames.Count();
            warunek = false;
            if (ile != 0)
            {
                warunek = true;
                category5Zdarzenia(cat, warunek, childrenCatNames);
                DeleteControls(parametryGroupBox.Name);
                DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);
                DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);

            }
            else
            {
                warunek = false;
                category5Zdarzenia(cat, warunek, childrenCatNames);
            }
        }

        //klikniecie na category6ComboBox
        private void category6_SelectedIndexChanged(object sender, EventArgs e)
        { }

        //===================================================================================================================================//
        //Metody do Tworzenia Controlek (Parametrów Dynamicznych danej kontrolki) ===========================================================//
        public void CreateStringAuctionControl(int i, int wysokosc,List<int> listNameDynamicControls, out List<int> tempList, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            StringAuctionControl stringAuctionControl = new StringAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            stringAuctionControl.Location = new Point(10, y);
            parametryGroupBox.Controls.Add(stringAuctionControl);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            tempList = listNameDynamicControls;
            y += 50;
        }
        public void CreateIntegerAuctionControl(int i, int wysokosc, List<int> listNameDynamicControls, out List<int> tempList, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            IntegerAuctionControl integerAuctionControl = new IntegerAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            integerAuctionControl.Location = new Point(10, y);
            parametryGroupBox.Controls.Add(integerAuctionControl);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            tempList = listNameDynamicControls;
            y += 50;
        }
        public void CreateFloatAuctionControl(int i, int wysokosc, List<int> listNameDynamicControls, out List<int> tempList, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            FloatAuctionControl floatAuctionControl = new FloatAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            floatAuctionControl.Location = new Point(10, y);
            parametryGroupBox.Controls.Add(floatAuctionControl);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            tempList = listNameDynamicControls;
            y += 50;
        }
        public void CreateComboBoxAuctionControl(int i, int wysokosc, List<int> listNameDynamicControls, out List<int> tempList, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            ComboBoxAuctionControl comboboxAuctionControl = new ComboBoxAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            comboboxAuctionControl.Location = new Point(10, y);
            parametryGroupBox.Controls.Add(comboboxAuctionControl);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            tempList = listNameDynamicControls;
            y += 50;
        }
        public void CreateRadioButtonAuctionControl(int i, int wysokosc, List<int> listNameDynamicControls, out List<int> tempList, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            RadioButtonAuctionControl radioButtonAuctionControl = new RadioButtonAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            radioButtonAuctionControl.Location = new Point(x, y);
            parametryGroupBox.Controls.Add(radioButtonAuctionControl); 

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            tempList = listNameDynamicControls;
            y += radioButtonAuctionControl.Height; // ustawianie odległosci miedzy nowymi obiektami
        }
        public void CreateCheckBoxAuctionControl(int i, int wysokosc, List<int> listNameDynamicControls, out List<int> tempList, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            CheckBoxAuctionControl checkBoxAuctionControl = new CheckBoxAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            checkBoxAuctionControl.Location = new Point(x, y);
            parametryGroupBox.Controls.Add(checkBoxAuctionControl);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            tempList = listNameDynamicControls;
            y += checkBoxAuctionControl.Height;
        }
        public void CreateFormaSprzedazyAuctionControl(List<int> listNameDynamicControls, out List<int> tempList)
        {
            //Tworzy sie Kontrolka
            string sellformdescTitleFormaSprzedazyComboBox = cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformdesc;
            string nameTempParamFormaSprzedazyComboBox = "";
            formaSprzedazyComboBox.Name = System.Convert.ToString(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformid);
            formaSprzedazyLabel.Text = cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformtitle;

            for (int j = 0; j < cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformdesc.Length; j++)
            {
                if ((sellformdescTitleFormaSprzedazyComboBox[j] == '|') || (j == cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformdesc.Length - 1))
                {
                    formaSprzedazyComboBox.Items.Add(System.Convert.ToString(nameTempParamFormaSprzedazyComboBox));
                    formaSprzedazyComboBox.Width = 200;
                    formaSprzedazyComboBox.Name = nameTempParamFormaSprzedazyComboBox;
                    nameTempParamFormaSprzedazyComboBox = "";
                }
                else
                {
                    nameTempParamFormaSprzedazyComboBox += sellformdescTitleFormaSprzedazyComboBox[j];
                }
            }

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformid);
            tempList = listNameDynamicControls;
        }
        public void CreateSzczegolyOfertyAuctionControl(List<int> listNameDynamicControls, out List<int> tempList,bool zFormaSprzedazy)
        {
            //Tworzy sie Kontrolka
            bool zaznaczonaFormaSprzedazy = zFormaSprzedazy;
            SzczegolyOfertyAuctionControl szczegolyOfertyAuctionControl = new SzczegolyOfertyAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, zaznaczonaFormaSprzedazy);
            szczegolyOfertyAuctionControl.Location = new Point(10, 50);
            parametrySzczegolowWMidTopPanelGroupBox.Controls.Add(szczegolyOfertyAuctionControl);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[3].sellformid);
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[4].sellformid);
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[5].sellformid);
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[6].sellformid);
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[7].sellformid);
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[14].sellformid);
            listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[24].sellformid);
            tempList = listNameDynamicControls;
        }
        public void CreatePaidAuctionControl(List<int> listNameDynamicControls, out List<int> tempList)
        {
            //Tworzy sie Kontrolka
            int y = 20;                     // Ustawienie początkowej lokalizaji(Wysokosc) dla Tworzących się obiektów
            for (int i = 35; i < 58; i++)   // Zakres 35-58 , poniewaz w Strukturze pobranych pól własnie te (id) odpowiadaja za rodzaje wystłki
            {
                PaidAuctionControl paidAuctionControl = new PaidAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
                paidAuctionControl.Location = new Point(10, y);
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Controls.Add(paidAuctionControl);
                //Dodaje do listy id pola (parametrów) formularza (id utworzonej kontrolki)
                listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
                listNameDynamicControls.Add(i+100);
                listNameDynamicControls.Add(i+200);
                y += 50;
            }
            tempList = listNameDynamicControls;
        }

        public void CreateLabelAuctionControl(int i, int wysokosc, out int y)
        {
            //Tworzy sie Kontrolka
            y = wysokosc;
            LabelControl a = new LabelControl(cat.SELLFORMFIELDSFORCATEGORY, i);
            a.Location = new Point(x,y);                       
            parametryGroupBox.Controls.Add(a);

            //Dodaje do listy id pola formularza (id utworzonej kontrolki)
            //listNameDynamicControls.Add(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid);
            //tempList = listNameDynamicControls;
            y += 50;
        }

        //klikniecie na confirmCategoryButton (BUTTON ZATWIERDZ)
        private void confirmCategoryButton_Click(object sender, EventArgs e)
        {
            x = 10;     // Punkt Szerokosc od ktorej beda sie tworzyc obiekty
            y = 20;     // Punkt Wysokosc od ktorej beda sie tworzyc obiekty
                //===================================================================================================================================//
                // Petla przebiega po liscie parametrów kategori. Wybiera z niej parametry danej Kategori. ==========================================//
                for (int i = 0; i < cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist.Length; i++)
                {  
                    if (((cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformopt == 1 || cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformopt == 8) && cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformcat != 0))
                    { // Warunek Jeśli (( Parametr jest wymagany == 1 lub opcjonalny == 8) i ( Parametr NIE ( != ) odnosi sie do wszystkich Kategori)
                        switch (cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformtype)
                        {                             
                            case 1: // 1- string
                                CreateStringAuctionControl(i, y, listNamesDynamicControls, out listNamesDynamicControls, out y);
                                break;
                            case 2: // 2- integer
                                CreateIntegerAuctionControl(i, y, listNamesDynamicControls, out listNamesDynamicControls, out y);
                                break;
                            case 3: // 3- float
                                CreateFloatAuctionControl(i, y, listNamesDynamicControls, out listNamesDynamicControls, out y);
                                break;
                            case 4: // 4- combobox
                                CreateComboBoxAuctionControl(i, y, listNamesDynamicControls, out listNamesDynamicControls, out y);
                                break;
                            case 5: // 5- RadioButton
                                CreateRadioButtonAuctionControl(i, y, listNamesDynamicControls, out listNamesDynamicControls, out y);
                                break;
                            case 6: // 6- checkbox
                                CreateCheckBoxAuctionControl(i, y, listNamesDynamicControls, out listNamesDynamicControls, out y);
                                break;
                            case 7:
                                CreateLabelAuctionControl(i, y, out y);
                                break;
                            case 8:
                                CreateLabelAuctionControl(i, y, out y);
                                break;
                            case 9:
                                CreateLabelAuctionControl(i, y, out y);
                                break;
                            case 13:
                                CreateLabelAuctionControl(i, y, out y);
                                break;
                            default:
                                break;
                        }
                    }
                }
                //Ustawienie widocznosci i rozmiarów Paneli po Zatwierdzeniu Kategori
                midPanel.Visible = true;
                parametryGroupBox.Visible = true;

            //========================================================================================================================//
            // Tworzenie Labela formaSprzedazy i comboBoxa ===========================================================================//
                CreateFormaSprzedazyAuctionControl(listNamesDynamicControls, out listNamesDynamicControls);
            /*
            string sellformdescTitleFormaSprzedazyComboBox = cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformdesc;
            string nameTempParamFormaSprzedazyComboBox = "";
            formaSprzedazyComboBox.Name = System.Convert.ToString(cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformid);
            formaSprzedazyLabel.Text = cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformtitle;

            for (int j = 0; j < cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformdesc.Length; j++)
            {
                if ((sellformdescTitleFormaSprzedazyComboBox[j] == '|') || (j == cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[27].sellformdesc.Length - 1))
                {
                    formaSprzedazyComboBox.Items.Add(System.Convert.ToString(nameTempParamFormaSprzedazyComboBox));
                    formaSprzedazyComboBox.Width = 200;
                    formaSprzedazyComboBox.Name = nameTempParamFormaSprzedazyComboBox;
                    nameTempParamFormaSprzedazyComboBox = "";
                }
                else
                {
                    nameTempParamFormaSprzedazyComboBox += sellformdescTitleFormaSprzedazyComboBox[j];
                }
            }
            //formaSprzedazyComboBox.SelectedIndex = 0;
            */
        }

        // (klikniecie) zaznaczenie formy sprzedazy
        private void formaSprzedazyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //=====================================================================================//
            // Sprawdzanie która forma sprzedaży została zaznaczona ===============================//
            bool zaznaczonaFormaSprzedazy = false;
            if (formaSprzedazyComboBox.SelectedIndex == 0)
            {
                zaznaczonaFormaSprzedazy = true;
            }
            //======================================================================================//
            // Po wybraniu formy sprzedazy pokazą sie Parametry(Cena,Stan,Liczba,...)===============//
            // Po wybraniu formy sprzedazy pokazą sie Rodzaje Platnosci i Wysylki    ===============//
            parametrySzczegolowWMidTopPanelGroupBox.Visible = true;                                 
            rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Visible = true;                            
            
            
            //======================================================================================//
            // Usuwanie(Czyszczenie) Kontrolek z parametrySzegolowSprzedazyWMidTopPanel ============//
            //DeleteControls(parametrySzczegolowWMidTopPanelGroupBox.Name);


            //=========================================================================================================================================================//
            //Tworzenie Kontroliki z Polami (Parametrami) "Liczba Przedmiotów", "Cena" ..... ==========================================================================================//
            CreateSzczegolyOfertyAuctionControl(listNamesDynamicControls, out listNamesDynamicControls,zaznaczonaFormaSprzedazy);

            //=========================================================================================================================================================//
            //Tworzenie Kontrolek zawierających "Rodzaj Wysyłki" - Label | "Pierwsza sztuka" - TextBox | "Kolejna sztuka" - TextBox | "Liczba w sztuk" - TextBox | ====//
            CreatePaidAuctionControl(listNamesDynamicControls, out listNamesDynamicControls);

            /*y = 20;    // Ustawienie początkowej lokalizaji(Wysokosc) dla Tworzących się obiektów
            for (int i = 35; i < 58; i++)   // Zakres 35-58 , poniewaz w Strukturze pobranych pól własnie te (id) odpowiadaja za rodzaje wystłki
            {
                PaidAuctionControl paidAuctionControl = new PaidAuctionControl(cat.SELLFORMFIELDSFORCATEGORY, i);
                paidAuctionControl.Location = new Point(10, y);
                rodzajePlatnosciIWysylkiWMidMidPanelGroupBox.Controls.Add(paidAuctionControl);
                y += 50;
            } */
            
            //==========================================================================================================================================================//
            dataGridView1.Rows.Add(listNamesDynamicControls.Count);
            listNamesDynamicControls.Sort();
            for (int i = 0; i < cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist.Length; i++)
            {
                for (int j = 0; j < listNamesDynamicControls.Count; j++)
                if (cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformid == listNamesDynamicControls[j])
                {     
                        //dataGridView1.Rows.Add(listNamesDynamicControls[i]);
                        dataGridView1.Rows[j].SetValues(listNamesDynamicControls[j],cat.SELLFORMFIELDSFORCATEGORY.sellformfieldslist[i].sellformtitle);
                        
                        
                        //dataGridView1ows[i].Cells[1].Value = listNamesDynamicControls[i];
                        ListaControlekTextBox.Text += (listNamesDynamicControls[j] + " ");
                }
            }
        }

        // Właściwosci
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

    }
}
