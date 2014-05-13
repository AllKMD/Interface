using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface._Interfaces
{
    interface ICategories
    {
        int getParentCatId(int catId);//zwraca id kategori nadrzednej
        string[] getChildrenNames(int catId);//zwraca tablice z nazwami podkategori
        int getCatId(string catName);//zwraca id kategori o podanej nazwie

    }
}
