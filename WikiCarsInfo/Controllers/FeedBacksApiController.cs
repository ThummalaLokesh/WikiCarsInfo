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
using WikiCarsInfo.Models;

namespace WikiCarsInfo.Controllers
{
    public class FeedBacksApiController : ApiController
    {
        private FeedBackContext db = new FeedBackContext();

        // GET: api/FeedBacksApi
        public IQueryable<FeedBack> GetFeedBacks()
        {
            return db.FeedBacks;
        }

        // GET: api/FeedBacksApi/5
        [ResponseType(typeof(FeedBack))]
        public IHttpActionResult GetFeedBack(int id)
        {
            FeedBack feedBack = db.FeedBacks.Find(id);
            if (feedBack == null)
            {
                return NotFound();
            }

            return Ok(feedBack);
        }

        // PUT: api/FeedBacksApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFeedBack(int id, FeedBack feedBack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != feedBack.FeedbackId)
            {
                return BadRequest();
            }

            db.Entry(feedBack).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedBackExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/FeedBacksApi
        [ResponseType(typeof(FeedBack))]
        public IHttpActionResult PostFeedBack(FeedBack feedBack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FeedBacks.Add(feedBack);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = feedBack.FeedbackId }, feedBack);
        }

        // DELETE: api/FeedBacksApi/5
        [ResponseType(typeof(FeedBack))]
        public IHttpActionResult DeleteFeedBack(int id)
        {
            FeedBack feedBack = db.FeedBacks.Find(id);
            if (feedBack == null)
            {
                return NotFound();
            }

            db.FeedBacks.Remove(feedBack);
            db.SaveChanges();

            return Ok(feedBack);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FeedBackExists(int id)
        {
            return db.FeedBacks.Count(e => e.FeedbackId == id) > 0;
        }
    }
}