using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using GolfScore.Models;
using Microsoft.Data.OData;

namespace GolfScore.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using GolfScore.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<CourseModels>("Course");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class CourseController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Course
        public IHttpActionResult GetCourse(ODataQueryOptions<CourseModels> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }
            CourseModels result = new CourseModels { Id = Guid.NewGuid(), Name = "My Sample Course" };
            List<CourseModels> a = new List<CourseModels> { result };
            return Ok<IEnumerable<CourseModels>>(a);

            // return Ok<IEnumerable<CourseModels>>(courseModels);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Course(5)
        public IHttpActionResult GetCourseModels([FromODataUri] System.Guid key, ODataQueryOptions<CourseModels> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<CourseModels>(courseModels);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Course(5)
        public IHttpActionResult Put([FromODataUri] System.Guid key, Delta<CourseModels> delta) // Update
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(courseModels);

            // TODO: Save the patched entity.

            // return Updated(courseModels);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Course
        public IHttpActionResult Post(CourseModels courseModels) // Add New
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(courseModels);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Course(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] System.Guid key, Delta<CourseModels> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(courseModels);

            // TODO: Save the patched entity.

            // return Updated(courseModels);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Course(5)
        public IHttpActionResult Delete([FromODataUri] System.Guid key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
