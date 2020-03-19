namespace Models
{
    /// <summary>
    /// Represents a category from the PetStore API.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique id of this <see cref="Category"/>.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Name of this <see cref="Category"/>.
        /// </summary>
        public string Name { get; set; }
    }
}
