//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task_table
    {
        public int task_id { get; set; }
        public string parent_task { get; set; }
        public string task { get; set; }
        public System.DateTime C_start_date { get; set; }
        public System.DateTime C_end_date { get; set; }
        public int C_priority { get; set; }
    }
}
