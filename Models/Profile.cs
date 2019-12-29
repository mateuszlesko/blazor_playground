using System;
using System.Collections;
using System.Collections.Generic;

namespace memespot_client.Models
{
    public class ProfileImg
    {
        private string path {get;set;}
        private Int32 height{get;set;}
        private Int32 width{get;set;}
        public ProfileImg(string? sPath)
        {
            this.path = @"\profilesImg\usersProfilesImg\"+sPath ?? @"\profilesImg\defaultProfilesImg\";
            SetSize();
        }
        public string GetPath()
        {
            return $"{path}";
        }
        public void SetSize(){
                width = 660;
                height = 480; 
        }
        public Int32[] GetSize()
        {
            return new Int32[]{width,height}; 
        }
    }
    
    public class Sex
    {
        public string nameSex{get;set;}
        public Sex(string name){
            this.nameSex = name;
        }
    }
    public class Profile
    {
        private string GenerateLogin()
        {
           Random rand = new Random();
            double x = rand.Next(0,100000);
            return $"Guest{x}";
        }
        private string setDefPicture()
        {
            string [] defaultProfImgs = new string[]{"default1.jpg","default2.png"};
            Random rand = new Random();
            int x = rand.Next(0,2);
            return defaultProfImgs[x];
        }
        public string login{get;set;}
        public ProfileImg profileImg{get;set;}

        public Sex sex {get;set;}
        
        public Profile(string l,ProfileImg img, Sex s){
            this.login = l ?? GenerateLogin();
            this.profileImg = img ?? new ProfileImg(setDefPicture());
            this.sex = s ?? new Sex("unknown");
        } 
        public string GetPath()
        {
            return profileImg.GetPath();
        }

    }
}