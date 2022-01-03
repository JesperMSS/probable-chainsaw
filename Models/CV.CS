using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CVSITEHT2021.Models
{
    public class CV
    {
        [Key]
        public int id { get; set; }

        public string education { get; set; }

        public string workplace { get; set; }

        public string competances { get; set; }
    }
}