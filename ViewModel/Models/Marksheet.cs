using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class Marksheet
    {
        public Student MyStudent { get; set; }
        public Assessment MyAssessment { get; set; }

        //Setting readonly property - We only use 'get'
        public  int Total
        {
            get
            {
                return MyAssessment.MVCMarks + MyAssessment.BootStrapMarks + MyAssessment.CSharpMarks;
            }
        }
    }
}