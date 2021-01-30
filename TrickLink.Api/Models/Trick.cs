namespace TrickLink.Api.Models
{
    /// <summary>
    /// This model represents a video of some trick.
    /// </summary>
    public class Trick
    {
        /// <summary>
        /// The unique ID of the trick.
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// The name of the trick.
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
    }
}