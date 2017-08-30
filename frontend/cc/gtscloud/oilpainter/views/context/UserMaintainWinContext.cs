using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.views.context
{
    class UserMaintainWinContext
    {
        /// <summary>
        /// 所有用户
        /// </summary>
        public IList<SecurityUserModel> AllUsers
        {
            get;set;
        }
    }
}
