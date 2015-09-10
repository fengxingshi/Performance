using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance.Models
{
    public class Dept
    {
        [JsonProperty("DepartmentID")]
        public long DepartmentID { get; set; }

        /// <summary>
        ///     所属组织机构（单位）的标识符。来自平台
        /// </summary>
        [JsonProperty("Organization")]
        public string Organization { get; set; }

        /// <summary>
        ///     部门编码。2-2-2结构，同单位内唯一
        /// </summary>
        [JsonProperty("Code")]
        public string Code { get; set; }

        /// <summary>
        ///     部门名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        ///     部门启用状态
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled { get; set; }

        /// <summary>
        ///     部门备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note { get; set; }

        /// <summary>
        ///     单位处室分类
        /// </summary>
        [JsonProperty("DepartmentCategory")]
        public long DepartmentCategory { get; set; }

        [JsonProperty("DepartmentCategoryName")]
        public string DepartmentCategoryName { get; set; }

        /// <summary>
        ///     单位处室性质
        /// </summary>
        [JsonProperty("DepartmentNature")]
        public long DepartmentNature { get; set; }

        [JsonProperty("DepartmentNatureName")]
        public string DepartmentNatureName { get; set; }

        /// <summary>
        ///     时间戳
        /// </summary>
        [JsonProperty("Ts")]
        public DateTime Ts { get; set; }

        /// <summary>
        ///     数据状态
        /// </summary>
        [JsonProperty("Rs")]
        public int Rs { get; set; }

        /// <summary>
        ///     部门排序号
        /// </summary>
        [JsonProperty("Idx")]
        public int Idx { get; set; }

        /// <summary>
        ///     处室负责人
        /// </summary>
        [JsonProperty("Leader")]
        public string Leader { get; set; }

        /// <summary>
        ///     分管该处室的一般绩效员
        /// </summary>
        [JsonProperty("JxAdministrator")]
        public string JxAdministrator { get; set; }

        /// <summary>
        ///     分管该处室的考评小组
        /// </summary>
        [JsonProperty("KpxzAdministrator")]
        public string KpxzAdministrator { get; set; }

        /// <summary>
        ///    上级处室流水号
        /// </summary>
        [JsonProperty("SuperiorDepartment")]
        public long SuperiorDepartment { get; set; }

        /// <summary>
        /// 是否参与考评
        /// </summary>
        [JsonProperty("IsJoinCheck")]
        public string IsJoinCheck { get; set; }

        /// <summary>
        ///     处室负责人名称
        /// </summary>
        [JsonProperty("LeaderName")]
        public string LeaderName { get; set; }


        /// <summary>
        ///     分管该处室的一般绩效员
        /// </summary>
        [JsonProperty("JxAdministratorName")]
        public string JxAdministratorName { get; set; }

    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Depts
    {
        [JsonProperty("DeptList")]
        public List<Dept> DeptList { get; set; }
    }
}
