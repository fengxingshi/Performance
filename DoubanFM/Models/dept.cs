using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanFM.Models
{
    public class dept
    {
        public long DepartmentID { get; set; }

        /// <summary>
        ///     所属组织机构（单位）的标识符。来自平台
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        ///     部门编码。2-2-2结构，同单位内唯一
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     部门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     部门启用状态
        /// </summary>
        public string Enabled { get; set; }

        /// <summary>
        ///     部门备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        ///     单位处室分类
        /// </summary>
        public long DepartmentCategory { get; set; }

        public string DepartmentCategoryName { get; set; }

        /// <summary>
        ///     单位处室性质
        /// </summary>
        public long DepartmentNature { get; set; }

        public string DepartmentNatureName { get; set; }

        /// <summary>
        ///     时间戳
        /// </summary>
        public DateTime Ts { get; set; }

        /// <summary>
        ///     数据状态
        /// </summary>
        public int Rs { get; set; }

        /// <summary>
        ///     部门排序号
        /// </summary>
        public int Idx { get; set; }

        /// <summary>
        ///     处室负责人
        /// </summary>
        public string Leader { get; set; }

        /// <summary>
        ///     分管该处室的一般绩效员
        /// </summary>
        public string JxAdministrator { get; set; }

        /// <summary>
        ///     分管该处室的考评小组
        /// </summary>
        public string KpxzAdministrator { get; set; }

        /// <summary>
        ///    上级处室流水号
        /// </summary>
        public long SuperiorDepartment { get; set; }

        /// <summary>
        /// 是否参与考评
        /// </summary>
        public string IsJoinCheck { get; set; }

        /// <summary>
        ///     处室负责人名称
        /// </summary>
        public string LeaderName { get; set; }


        /// <summary>
        ///     分管该处室的一般绩效员
        /// </summary>
        public string JxAdministratorName { get; set; }

    }
}
