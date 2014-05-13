using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.webapi;

namespace Interface._Classes
{
    class Auction
    {
        ItemInfoExt info;
        ItemCatList[] itemCatPath;
        ItemImageList[] itemImgList;
        AttribStruct[] itemAttrubList;
        PostageStruct[] itemPostageOptions;
        ItemPaymentOptions itemPaymentOptions;
        CompanyInfoStruct itemCompanyInfo;
        ProductStruct itemProductInfo;

        public Auction(long id,Session s)
        {
            info=s.allegroService.doShowItemInfoExt(s.SESSIONHANDLE, id, 0, 0, 0, 0, 0, 0, out itemCatPath, out itemImgList, out itemAttrubList, out itemPostageOptions, out itemPaymentOptions, out itemCompanyInfo, out itemProductInfo);
        }


        static public string getAuctionName(long id, Session s)
        {
            ItemInfoExt info;
            ItemCatList[] itemCatPath;
            ItemImageList[] itemImgList;
            AttribStruct[] itemAttrubList;
            PostageStruct[] itemPostageOptions;
            ItemPaymentOptions itemPaymentOptions;
            CompanyInfoStruct itemCompanyInfo;
            ProductStruct itemProductInfo;

            try
            {
                info = s.allegroService.doShowItemInfoExt(s.SESSIONHANDLE, id, 1, 0, 0, 0, 0, 0, out itemCatPath, out itemImgList, out itemAttrubList, out itemPostageOptions, out itemPaymentOptions, out itemCompanyInfo, out itemProductInfo);
                return info.itname;
            }
            catch
            {
                return "";
            }
            
        }
    }
}
