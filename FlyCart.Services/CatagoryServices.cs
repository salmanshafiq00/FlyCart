using FlyCart.Entities;
using FlyCart.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCart.Services
{
    public class CatagoryServices
    {
        public Catagory GetCatagory(int Id)
        {
            using (var context = new FlyCartContext())
            {
                return context.Catagories.Find(Id);
            }
        }
        public List<Catagory> GetCatagories()
        {
            using (var context = new FlyCartContext())
            {
              return  context.Catagories.ToList();
              
            }
        }
        public void CreateCatagory(Catagory catagory)
        {
            using (var context = new FlyCartContext())
            {
                context.Catagories.Add(catagory);
                context.SaveChanges();
            }
        }

        public void EditCatagory(Catagory catagory)
        {
            using (var context = new FlyCartContext())
            {
                context.Entry(catagory).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCatagory(Catagory catagory)
        {
            using (var context = new FlyCartContext())
            {
                context.Entry(catagory).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

       
    }
}
