using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataAccessLayer;

namespace Project
{
   public  class CompanyDataBase
   {
       private static CompanyDataBase _db;
       public CompanyEntities companyDB;

       private CompanyDataBase()
       {
            companyDB=new CompanyEntities();
       }

       public static CompanyDataBase Instance => _db ?? (_db = new CompanyDataBase());
   }
}
