//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManageStudent
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExam
    {
        public int subjectId { get; set; }
        public string stuId { get; set; }
        public string examName { get; set; }
        public Nullable<int> mark1st { get; set; }
        public Nullable<int> mark2nd { get; set; }
        public string status { get; set; }
    
        public virtual tblSubject tblSubject { get; set; }
        public virtual tblStudent tblStudent { get; set; }
    }
}