using System;

namespace memespot_client.Models
{
      public class MemeCategory
    {
        private string name {get;set;}
         
        public MemeCategory()
        {  
        } 
        public MemeCategory(string n)
        {  
            this.name = n;
        } 
         public void set_title(string Stitle){
           name = Stitle;
        }
        public string get_hash()
        {
            return $"#{this.name}";
        }

    }
}