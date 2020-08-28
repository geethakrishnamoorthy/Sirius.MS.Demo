using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sirius.MS.DAL.DBContext;
using Sirius.MS.DAL.Repositories.Interfaces;

namespace Sirius.MS.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        protected VBooksDBContext Db;
        protected T Model;
        protected bool resultStatus = false;

        public GenericRepository()
        {
            this.Db = new VBooksDBContext();
        }

        public GenericRepository(VBooksDBContext ctx)
        {
            this.Db = ctx;
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
                // Will load the full table of data, override if only a subset is required
                modelList = Db.Set<T>().ToList();
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
                Model = Db.Set<T>().Find(id);
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
                Db.Set<T>().Add(t);
                Db.SaveChanges();
                resultStatus = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(1);
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
                Db.Entry(t).State = EntityState.Modified;
                Db.SaveChanges();
                resultStatus = true;
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
                Model = Db.Set<T>().Find(id);
                if (Model != null)
                {
                    Db.Set<T>().Remove(Model);
                    Db.SaveChanges();
                    resultStatus = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return await Task.FromResult(resultStatus);
        }
        private bool disposed = false;




        /// <summary>
        ///Dispose the object used
        /// </summary>
        /// <param name=""></param>
        /// <returns>no values</returns>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
            {
                Db.Dispose();
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

