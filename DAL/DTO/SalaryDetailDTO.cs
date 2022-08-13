using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDetailDTO
    {
        public int EmployeeID { get; set; } //0
        public int UserNo { get; set; } //1
        public string Name { get; set; }//2
        public string Surname { get; set; }//3
        public string DepartmentName { get; set; }//4
        public string PositionName { get; set; }//5
        public int DepartmentID { get; set; }//6
        public int PositionID { get; set; }//7
        public string MonthName { get; set; }//8
        public int SalaryYear { get; set; }//9
        public int MonthID { get; set; }//10
        public int SalaryAmount { get; set; }//11
        public int SalaryID { get; set; }//12
        public int OldSalary { get; set; }//13

    }
}
