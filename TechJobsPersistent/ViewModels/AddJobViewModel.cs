using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        //job's name, selected employer's Id, and a list of all employers as SelectListItem
        public int JobId { get; set; }

        public string Name { get; set; }

        public int EmployerId { get; set; }

        public List<Employer> Employers { get; set; }

    }
}
