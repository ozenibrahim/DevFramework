using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQeryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        public IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); }
        }
    }
}
