 using System;
using System.Collections.Generic;
using hobnobReact.Models;

namespace hobnobReact.Data
{
    public interface IhobnobRepo
    {
        bool SaveChanges();
        IEnumerable<Menu> GetAllmenus();
        Menu GetMenuById(int id);
        void CreateMenu(Menu mu);
        void updateMenu(Menu mu);
       
    }
}