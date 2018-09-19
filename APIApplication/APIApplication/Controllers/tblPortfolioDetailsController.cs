using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;


namespace APIApplication.Controllers
{
    public class tblPortfolioDetailsController : ApiController
    {
        

        // GET: api/tblPortfolioDetails
        public IQueryable<tblPortfolioDetail> GettblPortfolioDetails()
        {
            //return db.tblPortfolioDetails;
            var portfolioList = DBOperations.GetPortfolioDetails();
            return portfolioList;
        }

        // GET: api/tblPortfolioDetails/5
        [ResponseType(typeof(tblPortfolioDetail))]
        public IHttpActionResult GettblPortfolioDetail(string companyName)
        {
            var tblPortfolioDetail1 = DBOperations.GetPortfolioByID(companyName);
            if (tblPortfolioDetail1 == null)
            {
                return NotFound();
            }

            return Ok(tblPortfolioDetail1);
        }

        // PUT: api/tblPortfolioDetails/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PuttblPortfolioDetail(string id, tblPortfolioDetail tblPortfolioDetail1)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != tblPortfolioDetail1.PortFolioName)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(tblPortfolioDetail1).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!tblPortfolioDetailExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/tblPortfolioDetails
        [ResponseType(typeof(tblPortfolioDetail))]
        public IHttpActionResult PosttblPortfolioDetail(tblPortfolioDetail tblPortfolioDetail1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            

            try
            {
                DBOperations.InsertPortfolioDetails(tblPortfolioDetail1);
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }

            return CreatedAtRoute("DefaultApi", new { id = tblPortfolioDetail1.PortFolioName }, tblPortfolioDetail1);
        }

        //// DELETE: api/tblPortfolioDetails/5
        //[ResponseType(typeof(tblPortfolioDetail))]
        //public IHttpActionResult DeletetblPortfolioDetail(string id)
        //{
        //    tblPortfolioDetail tblPortfolioDetail = db.tblPortfolioDetails.Find(id);
        //    if (tblPortfolioDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    db.tblPortfolioDetails.Remove(tblPortfolioDetail);
        //    db.SaveChanges();

        //    return Ok(tblPortfolioDetail);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool tblPortfolioDetailExists(string id)
        //{
        //    return db.tblPortfolioDetails.Count(e => e.PortFolioName == id) > 0;
        //}
    }
}