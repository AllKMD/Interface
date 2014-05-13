using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using Interface.webapi;
using Interface._Interfaces;

namespace kodMacka
{
    public class Categories:ICategories
    {
        private CatInfoType[] catTree;
        private AllegroWebApiService allegroService;



        public Categories(AllegroWebApiService allegroService,string webAPIKey,out long verKey,out string verString)
        {
            this.allegroService = allegroService;
            catTree = allegroService.doGetCatsData(1, 0, webAPIKey, out verKey, out verString);
        }

        //METODY
        public int getParentCatId(int catId)//zwraca id kategori nadrzednej
        {
            for (int i = 0; i < catTree.Length; i++)
            {
                if (catTree[i].catid == catId)
                {
                    return catTree[i].catparent;
                }
            }
            throw new Exception("category not found");
        }
        public string[] getChildrenNames(int catId)//zwraca tablice z nazwami podkategori
        {
            List<string> names = new List<string>();

            for (int i = 0; i < catTree.Length; i++)
            {
                if(catTree[i].catparent==catId)
                {
                    names.Add(catTree[i].catname);
                }
            }
            return names.ToArray();
        }
        public int getCatId(string catName)//zwraca id kategori o podanej nazwie
        {
            for (int i = 0; i < catTree.Length; i++)
            {
                if (catTree[i].catname == catName)
                {
                    return catTree[i].catid;
                }
            }
            throw new Exception("category not found");
        }

        //WLASCIWOSCI
        CatInfoType[] CATEGORYTREE
        {
            get { return catTree; }
            set { }
        }

    }
}
