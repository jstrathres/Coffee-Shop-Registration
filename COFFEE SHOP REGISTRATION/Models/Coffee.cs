namespace COFFEE_SHOP_REGISTRATION.Models
{
    public class Coffee
    {
        public string name { get; set; }
     
        public string lastname { get; set; }
        public string email { get; set; }

        public string password { get; set; }
        public bool allergies { get; set; }

        public string Flavor { get; set; }
        //typically this is sent thru an encryption
    }
}
