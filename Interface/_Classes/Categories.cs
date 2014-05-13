using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using Interface.webapi;
using Interface._Interfaces;

namespace Interface._Classes
{
    public class Categories:ICategories
    {
        private AllegroWebApiService allegroService;
        const string webAPIKey = "7dda4ce4";
        private Categories cat;
        private CatInfoType[] catsData;
        private SellFormType[] sellFormFields;
        private SellFormFieldsForCategoryStruct sellFormFieldsForCategory;
        private object[] tempCatsArray;

        private int catid;
        private long verKey;
        private string verString;


        public Categories(AllegroWebApiService allegroService,string webAPIKey,out long verKey,out string verString)
        {
            this.allegroService = allegroService;
            catsData = allegroService.doGetCatsData(1, 0, webAPIKey, out verKey, out verString);
            sellFormFields = allegroService.doGetSellFormFieldsExt(1, verKey, webAPIKey, out verKey, out verString);
            
            ArrayList tempCats = new ArrayList();
            for (int i = 0; i < catsData.Length; i++)
            {
                if (catsData[i].catparent == 0)
                {
                    tempCats.Add(catsData[i].catname);
                }
            }
            tempCatsArray = tempCats.ToArray();
        }

        //METODY
        public int getParentCatId(int catId)//zwraca id kategori nadrzednej
        {
            for (int i = 0; i < catsData.Length; i++)
            {
                if (catsData[i].catid == catId)
                {
                    return catsData[i].catparent;
                }
            }
            throw new Exception("category not found");
        }
        public string[] getChildrenNames(int catId)//zwraca tablice z nazwami podkategori
        {
            List<string> names = new List<string>();

            for (int i = 0; i < catsData.Length; i++)
            {
                if(catsData[i].catparent==catId)
                {
                    names.Add(catsData[i].catname);
                }
            }
            return names.ToArray();
        }
        public int getCatId(string catName)//zwraca id kategori o podanej nazwie
        {
            for (int i = 0; i < catsData.Length; i++)
            {
                if (catsData[i].catname == catName)
                {
                    return catsData[i].catid;
                }
            }
            throw new Exception("category not found");
        }

        //WLASCIWOSCI
        public Categories CAT
        {
            get
            {
                return this.cat;
            }
            set 
            {
                cat=value;
            }
        }
        public CatInfoType[] CATSDATA
        {
            get
            {
                return this.catsData;
            }
            set
            {
                catsData = value;
            }
        }
       // private SellFormType[] sellFormFields;
       // private SellFormFieldsForCategoryStruct sellFormFieldsForCategory;
        public SellFormType[] SELLFORMFIELDS
        {
            get
            {
                return this.sellFormFields;
            }
            set
            {
                sellFormFields = value;
            }
        }

        public SellFormFieldsForCategoryStruct SELLFORMFIELDSFORCATEGORY
        {
            get
            {
                return this.sellFormFieldsForCategory;
            }
            set
            {
                sellFormFieldsForCategory = value;
            }
        }
        public object[] TEMPCATSARRAY
        {
            get
            {
                return this.tempCatsArray;
            }
            set
            {
                tempCatsArray = value;
            }
        }

        public string VERSTRING
        {
            get
            {
                return this.verString;
            }
            set
            {
                verString = value;
            }
        }
        public long VERKEY
        {
            get
            {
                return this.verKey;
            }
            set
            {
                verKey = value;
            }
        }
        public int CATID
        {
            get
            {
                return this.catid;
            }
            set
            {
                catid = value;
            }
        }

    }
}

