using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrickLink.Api.Models;

namespace TrickLink.Api.Controllers
{
    [ApiController]
    [Route("api/tricks")]
    public class Tricks : ControllerBase
    {
        #region Private Fields
        private readonly TrickyStore trickStore;
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor. Initializes the controller with
        /// a reference to the trick library.
        /// </summary>
        /// <param name="trickStore">The trick library</param>
        public Tricks(TrickyStore trickStore)
        {
            this.trickStore = trickStore;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Api endpoint to get all the available tricks.
        /// </summary>
        /// <remarks>The endpoint would be /api/tricks</remarks>
        /// <returns></returns>
        [HttpGet]
        public IActionResult All() => Ok(trickStore.Tricks);

        /// <summary>
        /// Api endpoint to get a specific trick.
        /// </summary>
        /// <remarks>The endpoint would be /api/tricks/{id}</remarks>
        /// <param name="id">The ID of the specific trick to get</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(trickStore.Tricks.FirstOrDefault(trick => trick.Id.Equals(id)));

        /// <summary>
        /// Api endpoint to create a trick submitted with a POST.
        /// </summary>
        /// <remarks>The endpoint would be /api/tricks/{id}</remarks>
        /// <param name="trick">The trick to create</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] Trick trick)
        {
            trickStore.AddTrick(trick);
            return Ok();
        }

        /// <summary>
        /// Api endpoint for updating an exiting trick. The id
        /// of the trick to update is contained within the trick
        /// that is sent.
        /// </summary>
        /// <remarks>The endpoint would be /api/tricks</remarks>
        /// <param name="trick">The updated tick</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Trick trick)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Api endpoint for deleting a specific trick.
        /// </summary>
        /// <remarks>The endpoint would be /api/tricks/{id}</remarks>
        /// <param name="id">The id of the trick to delete</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}