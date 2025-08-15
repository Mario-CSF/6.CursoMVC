using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _6.CursoMVC.Models.TableViewModels
{
    public class UserTableViewModels
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int?  Edad { get; set; }
        public string Password { get; internal set; }
    }
}