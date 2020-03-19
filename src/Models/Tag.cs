namespace Unify.PetStore.Models
{
    /// <summary>
    /// Represents a tag from the PetStore API.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Unique id of this <see cref="Tag"/>.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Name of this <see cref="Tag"/>.
        /// </summary>
        public string Name { get; set; }
    }
}
