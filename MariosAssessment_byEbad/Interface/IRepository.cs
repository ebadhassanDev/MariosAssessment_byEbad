using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosAssessment_byEbad.Interface
{
    /// <summary>
    /// Interface representing a repository for generic data access.
    /// </summary>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Retrieves all entities of type T from the database.
        /// </summary>
        /// <returns>An IEnumerable collection containing all entities of type T.</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Gets an entity of type T by its ID.
        /// </summary>
        /// <param name="id">The identifier of the entity to retrieve.</param>
        /// <returns>The entity of type T with the specified ID, or null if not found.</returns>
        T GetById(int id);
        /// <summary>
        /// Adds a new entity of type T to the database.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);
        /// <summary>
        /// Updates an existing entity of type T in the database.
        /// </summary>
        /// <param name="entity">The entity with updated properties.</param>
        void Update(T entity);
        /// <summary>
        /// Deletes an entity of type T from the database by its ID.
        /// </summary>
        /// <param name="id">The identifier of the entity to delete.</param>
        void Delete(int id);
    }
}
