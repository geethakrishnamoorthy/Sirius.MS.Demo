using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sirius.MS.BAL.Managers.Interfaces;
using Sirius.MS.DAL.Repositories;

namespace Sirius.MS.BAL.Managers
{
    public class GenericManager<T> : IManager<T> where T : class, new()
    {
        protected GenericRepository<T> genericRepository;
        protected T Model;
        protected bool resultStatus = false;
        private bool disposed = false;

        public GenericManager()
        {
            this.genericRepository = new GenericRepository<T>();
        }

        public GenericManager(GenericRepository<T> ctx)
        {
            this.genericRepository = ctx;
        }

        /// <summary>
        /// Load the details from Table of <T>
        /// </summary>
        /// <param name=""></param>
        /// <returns>List<T></returns>
        public virtual async Task<List<T>> LoadList()
        {
            List<T> modelList = new List<T>();
            try
            {
                modelList = await genericRepository.LoadList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(modelList);
        }

        /// <summary>
        ///Load the details from Table of<T> based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        public virtual async Task<T> Load(long id)
        {
            try
            {
                Model = await genericRepository.Load(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(Model);
        }
        /// <summary>
        ///Create the new entry in Table of<T>
        /// </summary>
        /// <param name="T"></param>
        /// <returns>no values</returns>
        public virtual async Task<long> Create(T t)
        {
            try
            {
                long id = await genericRepository.Create(t);
                return await Task.FromResult(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        ///Update the entry in Table of<T> based on Id
        /// </summary>
        /// <param name="T"></param>
        /// <returns>no values</returns>
        public virtual async Task<bool> Update(T t)
        {
            try
            {
                resultStatus = await genericRepository.Update(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(resultStatus);
        }
        /// <summary>
        ///Delete the entry in Table of<T> based on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>no values</returns>
        public virtual async Task<bool> Delete(long id)
        {
            try
            {
                resultStatus = await genericRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(resultStatus);
        }



        /// <summary>
        ///Dispose the object used
        /// </summary>
        /// <param name=""></param>
        /// <returns>no values</returns>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                genericRepository.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
