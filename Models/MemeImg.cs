using System;
namespace memespot_client.Models
{
   public class MemeImg
    {
        private string path {get;set;}
        private Int32 height{get;set;}
        private Int32 width{get;set;}
        public void set_paths(string Spath){
            path = @"\memesImg\"+Spath;
        }
        public MemeImg(){}
        public MemeImg(string sPath)
        {
            this.path = @"\memesImg\"+sPath;
            SetSize();
        }
        public string GetPath()
        {
            return $"{path}";
        }
        public void SetSize(){
            try
            {
                Console.WriteLine(@".\..\..\wwwroot"+GetPath());
                System.Drawing.Image image = System.Drawing.Image.FromFile(@".\..\..\wwwroot"+GetPath());
                width = image.Width;
                height = image.Height;
            }
            catch(System.IO.FileNotFoundException e)
            {
                width = 660;
                height = 480;
            }
            
        }
        public Int32[] GetSize()
        {
            return new Int32[]{width,height}; 
        }
    }
}