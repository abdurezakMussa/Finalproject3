

using System;
using System.Collections.Generic;
using System.Linq;
using hobnobReact.Models;

namespace hobnobReact.Data
{
    public class SqlHobnobRepo : IhobnobRepo
    {
      
      private readonly HobnobContext _context;
      public SqlHobnobRepo(HobnobContext context)
      {
          _context=context;
      }

        public void CreateMenu(Menu mu)
        {
            if(mu==null)
            {
                throw new ArgumentNullException(nameof(mu));
            }
            _context.Menus.Add(mu);// call save method to save
        }

        public IEnumerable<Menu> GetAllmenus()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Menu> GetAllpmenus()
        {
           return _context.Menus.ToList();
        }

        public Menu GetMenuById(int id)
        {
            
            return _context.Menus.FirstOrDefault(m=>m.Id==id);
             
        }

        public bool SaveChanges() //to save all the virb throw save method
        {
            return (_context.SaveChanges()>=0);
        }
    }
}
