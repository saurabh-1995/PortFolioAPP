using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBOperations
    {
        static DBModelEntities DBContext;

        static DBOperations()
        {
            DBContext = new DBModelEntities();
        }

        public static IQueryable<tblCompanyDetail> GetCompanyDetails()
        {
            return DBContext.tblCompanyDetails;
        }
        public static IQueryable<tblPortfolioDetail> GetPortfolioDetails()
        {
            return DBContext.tblPortfolioDetails;
        }

        public static tblCompanyDetail GetCompanyByID(string id)
        {
            tblCompanyDetail tblCompanyDetail1 = DBContext.tblCompanyDetails.Find(id);
            return tblCompanyDetail1;
        }

        public static tblPortfolioDetail GetPortfolioByID(string companyName)
        {
            tblPortfolioDetail tblPortfolioDetail1 = DBContext.tblPortfolioDetails.Find(companyName);
            return tblPortfolioDetail1;
        }

        public static void InsertCompanyDetails(tblCompanyDetail tblCompanyDetail1)
        {

            DBContext.tblCompanyDetails.Add(tblCompanyDetail1);
            try
            {
                DBContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }

        public static void InsertPortfolioDetails(tblPortfolioDetail tblPOrtfolioDetail1)
        {

            DBContext.tblPortfolioDetails.Add(tblPOrtfolioDetail1);
            try
            {
                DBContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
        }
    }
}
