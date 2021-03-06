using AutoMapper;
using IM.BusinessLayer.Abstract;
using IM.BusinessLayer.helper;
using IM.DataAccessLayer.Abstract;
using IM.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IM.BusinessLayer.Concrete
{
    public class GearTyPeManager : IDataBusinessService<GearType>
    {
        private IDataAccessDal<GearType> _dataAccessDal;
        private readonly IMapper _mapper;

        public GearTyPeManager(IDataAccessDal<GearType> dataAccessDal, IMapper mapper)
        {
            _dataAccessDal = dataAccessDal;
            _mapper = mapper;
        }
        public void Add(GearType entity)
        {
            _dataAccessDal.Add(entity);
        }

        public GearType Get(int id)
        {
            return _dataAccessDal.Get(id);
        }

        public List<GearType> GetAll()
        {
            var GearType = _mapper.Map<List<GearType>>(_dataAccessDal.GetAll());
            return GearType;
        }

        public IEnumerable<GearType> GetFilter(Expression<Func<GearType, bool>> expression)
        {
            return _dataAccessDal.GetFilter(expression);
        }

        public void Remove(int id)
        {
            _dataAccessDal.Remove(id);
        }

        public void RemoveAll(GearType t)
        {
            _dataAccessDal.RemoveAll(t);
        }

        public void Update(GearType t)
        {
            _dataAccessDal.Update(t);
        }

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
            }

            disposed = true;
        }
    }
}
