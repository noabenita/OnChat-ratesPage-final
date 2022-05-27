using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnChat.Models;
using OnChat.Services;

namespace OnChat.Controllers
{
    public interface IRatesController 
    {
        public List<Rates> GetAll();

        public Rates Get(string id);

        public void Delete(string name);

        public void Edit(int rate, string feedback, string id);

        public void Create(int rate, string feedback, string name);
        public List<Rates> GetAllByName(string query);


    }
}
