using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class NirsModel
    {
        [DisplayName("Название проекта")]
        public string ProjectName { get; set; }

        [DisplayName("Название научной работы")]
        public string ResearchName { get; set; }

        [DisplayName("Имя студента")]
        public string StudentName { get; set; }

        [DisplayName("Название университета")]
        public string UniversityName { get; set; }

        [DisplayName("Дата начала")]
        public DateTime StartDate { get; set; }

        [DisplayName("Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }

}