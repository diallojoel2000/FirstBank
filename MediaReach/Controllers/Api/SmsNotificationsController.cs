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
using DataFactoryMr.Models;

namespace MediaReach.Controllers.Api
{
    public class SmsNotificationsController : ApiController
    {
        private MediaReachContext db = new MediaReachContext();

        // GET: api/SmsNotifications
        public IQueryable<SmsNotification> GetSmsNotifications()
        {
            return db.SmsNotifications;
        }

        // GET: api/SmsNotifications/5
        [ResponseType(typeof(SmsNotification))]
        public IHttpActionResult GetSmsNotification(long id)
        {
            SmsNotification smsNotification = db.SmsNotifications.Find(id);
            if (smsNotification == null)
            {
                return NotFound();
            }

            return Ok(smsNotification);
        }

        // PUT: api/SmsNotifications/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSmsNotification(long id, SmsNotification smsNotification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != smsNotification.SmsNotificationId)
            {
                return BadRequest();
            }

            db.Entry(smsNotification).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmsNotificationExists(id))
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

        // POST: api/SmsNotifications
        [ResponseType(typeof(SmsNotification))]
        public IHttpActionResult PostSmsNotification(SmsNotification smsNotification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SmsNotifications.Add(smsNotification);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = smsNotification.SmsNotificationId }, smsNotification);
        }

        // DELETE: api/SmsNotifications/5
        [ResponseType(typeof(SmsNotification))]
        public IHttpActionResult DeleteSmsNotification(long id)
        {
            SmsNotification smsNotification = db.SmsNotifications.Find(id);
            if (smsNotification == null)
            {
                return NotFound();
            }

            db.SmsNotifications.Remove(smsNotification);
            db.SaveChanges();

            return Ok(smsNotification);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SmsNotificationExists(long id)
        {
            return db.SmsNotifications.Count(e => e.SmsNotificationId == id) > 0;
        }
    }
}