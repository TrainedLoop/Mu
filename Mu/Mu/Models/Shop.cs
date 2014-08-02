using Mu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Models
{
    public class Shop
    {
        public MembInfo User { get; set; }
        public Shop(MembInfo user)
        {
            User = user;
        }

        public static int GetCount(MembInfo user)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var cart = section.QueryOver<ShopKart>().Where(i => i.User == user && i.IsOpen == true).SingleOrDefault();
            if (cart == null)
                return 0;
            if (cart.Requests == null)
                return 0;
            return cart.Requests.Count();
        }

        public ShopKart ShowKart()
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var cart = section.QueryOver<ShopKart>().Where(i => i.User == User && i.IsOpen == true).SingleOrDefault();
            return cart;
        }
        public void AddItemOnKart(string itemName, decimal value, bool Add)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            ShopKart cart = section.QueryOver<ShopKart>().Where(i => i.User == User && i.IsOpen == true).SingleOrDefault();
            if (cart == null)
                cart = new ShopKart() { User = User, IsOpen = true, IsDeliverd = false, IsPaid = false };

            if (cart.Requests == null)
            {
                cart.Requests = new List<ShopRequest>();
                section.Save(cart);
                section.Flush();
            }

            var item = section.QueryOver<ShopItem>().Where(i => i.ItemName == itemName && i.ItemValue == (Add ? value + 5 : value) && i.AddOptions == Add).SingleOrDefault();
            if (item == null)
            {
                item = new ShopItem()
                {
                    ItemName = itemName,
                    ItemValue = Add ? value + 5 : value,
                    AddOptions = Add

                };
                section.Save(item);
                section.Flush();
            }
            cart.Requests.Add(new ShopRequest { Cart = cart, Item = item });
        }

        public void RemoveItemFromKart(int requestId)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var cart = ShowKart();
            cart.Requests.Remove(cart.Requests.Where(i => i.Id == requestId).Single());

        }


    }
}