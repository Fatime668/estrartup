using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estartup.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
