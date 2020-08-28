using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sirius.MS.DAL.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        /// <summary>
        /// Load the details from Table of <T>
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<T></returns>
        Task<List<T>> LoadList();

        /// <summary>
        ///Load the details from Table of<T> based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        Task<T> Load(long id);

        /// <summary>
        ///Create the new entry in Table of<T>
        /// </summary>
        /// <param name="T"></param>
        /// <returns>no values</returns>
        Task<long> Create(T t);

        /// <summary>
        ///Update the entry in Table of<T> based on Id
        /// </summary>
        /// <param name="T"></param>
        /// <returns>no values</returns>
        Task<bool> Update(T t);

        /// <summary>
        ///Delete the entry in Table of<T> based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>no values</returns>
        Task<bool> Delete(long id);


    }
}