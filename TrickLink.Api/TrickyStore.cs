using System.Collections.Generic;
using TrickLink.Api.Models;

namespace TrickLink.Api
{
    /// <summary>
    /// The library containing information on all the tricks.
    /// </summary>
    public class TrickyStore
    {
        #region Private Fields
        /// <summary>
        /// All the available tricks.
        /// </summary>
        private readonly List<Trick> tricks;
        #endregion

        #region Public Properties
        /// <summary>
        /// All the available tricks.
        /// </summary>
        public IEnumerable<Trick> Tricks => tricks;
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor.
        /// </summary>
        public TrickyStore()
        {
            tricks = new List<Trick>();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Add a trick to the existing trick library.
        /// </summary>
        /// <param name="trick">Trick to add</param>
        public void AddTrick(Trick trick)
        {
            trick.Id = tricks.Count + 1;
            tricks.Add(trick);
        }
        #endregion
    }
}