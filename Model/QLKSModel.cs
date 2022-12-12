using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKhachSan.Model;

namespace QLKhachSan.Model
{
    class QLKSModel
    {
        private QLKSModel() {}

        private static QLKSModel instance = null;
        private QLKSEntities Data;

        private static readonly object _lock = new object();

        public static QLKSModel GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new QLKSModel();
                        instance.Data = new QLKSEntities();
                    }
                }
            }
            return instance;
        }

        public QLKSEntities GetData()
        {
            return this.Data;
        }
    }
}
