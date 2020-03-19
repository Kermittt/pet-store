using System.Collections.Generic;
using Models.Enumerations;

namespace Models
{
    public class Pet
    {
        /// <summary>
        /// Unique id of the <see cref="Pet"/>.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the <see cref="Pet"/>.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of urls that contain photos of this <see cref="Pet"/>.
        /// </summary>
        public List<string> PhotoUrls { get; set; }

        /// <summary>
        /// <see cref="Tag"/>s that have been associated with this <see cref="Pet"/>.
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Current status of this <see cref="Pet"/>.
        /// </summary>
        public PetStatus Status { get; set; }
    }
}
