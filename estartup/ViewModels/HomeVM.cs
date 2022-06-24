using estartup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estartup.ViewModels
{
    public class HomeVM
    {
        public Setting Setting { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
        public List<Post> Posts { get; set; }
    }
}
