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
        public int Id { get; set; }

        public string Name { get; set; }

        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public int SkillId { get; set; }

        public List<SelectListItem> Skills { get; set; }

        public AddJobViewModel() { }

        public AddJobViewModel(List<Employer> listEmployers, List<Skill> listSkills)
        {
            Employers = new List<SelectListItem>();

            Skills = new List<SelectListItem>();

            foreach (Employer employer in listEmployers)
            {
                Employers.Add(new SelectListItem { Value = employer.Id.ToString(), Text = employer.Name });
            }

            foreach (Skill skill in listSkills)
            {
                Skills.Add(new SelectListItem { Value = skill.Id.ToString(), Text = skill.Name });
            }
        }


    }
}
