using DataAccessLayer.Entities;
using Newtonsoft.Json;

namespace WEBDEMO.Session_Extension_Methods
{
    public static class SessionExtension
    {

        public static void SetCart(this ISession session, Cart cart)
        {
            session.SetString("Cart", JsonConvert.SerializeObject(cart));



        }
        public static Cart GetCart(this ISession session)
        {
            var cartJson = session.GetString("Cart");
            return cartJson == null ? new Cart() : JsonConvert.DeserializeObject<Cart>(cartJson);

        }
    }
}
