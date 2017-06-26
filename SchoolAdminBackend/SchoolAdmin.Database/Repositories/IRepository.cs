using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAdmin.Database.Repositories
{
    /// <summary>
    /// Interface for all repositories. Repository incapsulates CRUD operations with entity
    /// </summary>
    /// <typeparam name="T">Type of entity to be wrapped</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Get IQueryable entity containing all entities
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetQueryable();
        /// <summary>
        /// Inserts <paramref name="entity"/> to database
        /// </summary>
        /// <param name="entity">Entity to be inserted</param>
        /// <returns>Updated entity</returns>
        T Add(T entity);
        /// <summary>
        /// Updates existing entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        void Update(T entity);
        /// <summary>
        /// Deletes entity from database
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        void Delete(T entity);
    }
}
