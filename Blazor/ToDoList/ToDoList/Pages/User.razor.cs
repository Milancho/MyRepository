using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Pages
{
    public partial class User
    {
        public List<BagsKorisnik> DataSource = null;

        protected override async Task OnInitializedAsync()
        {
            DataSource = await Context.BagsKorisnik.ToListAsync();

            var xx = DataSource;
        }
    }
}
