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
using DataAccessLayer;

namespace APIApplication.Controllers
{
    public class tblCompanyDetailsController : ApiController
    {
        

        // GET: api/tblCompanyDetails
        public IQueryable<tblCompanyDetail> GettblCompanyDetails()
        {
            var companyList = DBOperations.GetCompanyDetails();
            return companyList;
        }

        // GET: api/tblCompanyDetails/5
        [ResponseType(typeof(tblCompanyDetail))]
        public IHttpActionResult GettblCompanyDetail(string id)
        {

            var companyDetails = DBOperations.GetCompanyByID(id);
            if (companyDetails == null)
            {
                return NotFound();
            }

            return Ok(companyDetails);
        }

        //// PUT: api/tblCompanyDetails/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PuttblCompanyDetail(string id, tblCompanyDetail tblCompanyDetail1)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != tblCompanyDetail1.CompanyName)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(tblCompanyDetail1).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!tblCompanyDetailExists(id))
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

        // POST: api/tblCompanyDetails
        [ResponseType(typeof(tblCompanyDetail))]
        public IHttpActionResult PosttblCompanyDetail(tblCompanyDetail tblCompanyDetail1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                DBOperations.InsertCompanyDetails(tblCompanyDetail1);
            }
            catch(DbUpdateException ex)
            {
                throw ex;
            }         

            return CreatedAtRoute("DefaultApi", new { id = tblCompanyDetail1.CompanyName }, tblCompanyDetail1);
        }

        //// DELETE: api/tblCompanyDetails/5
        //[ResponseType(typeof(tblCompanyDetail))]
        //public IHttpActionResult DeletetblCompanyDetail(string id)
        //{
        //    tblCompanyDetail tblCompanyDetail = db.tblCompanyDetails.Find(id);
        //    if (tblCompanyDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    db.tblCompanyDetails.Remove(tblCompanyDetail);
        //    db.SaveChanges();

        //    return Ok(tblCompanyDetail);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool tblCompanyDetailExists(string id)
        //{
        //    return db.tblCompanyDetails.Count(e => e.CompanyName == id) > 0;
        //}
    }
}