using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<EngineerMachine>();

        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        public string Status {get; set;}
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime LicensedDate{ get; set; }
       

        public virtual ICollection<EngineerMachine> JoinEntities { get;}

    }
}