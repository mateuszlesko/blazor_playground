using System;
using System.Collections;
using System.Collections.Generic;

namespace memespot_client.Models
{
    public class Meme
        {
            private MemeCategory memeCategory {get;set;}
            private MemeImg memeImg {get;set;}
            private string title {get;set;}
            private DateTime uploadDate = System.DateTime.Now;

            public Int32 votes = 0;

            public Meme(){}
            public Meme(MemeCategory c,MemeImg img,string title)
            {
                this.memeCategory = c ?? null;
                this.memeImg = img ?? null;
                this.title = title ?? "Untitled";
                this.votes = 0;
            }
            public void setMemeCategory(MemeCategory c)
            {
                this.memeCategory = c;
            }
            public void setMemeImg(MemeImg img)
            {
                this.memeImg = img;
            }
            public void setMemeTitle(string s)
            {
            this.title = s;
            }
            //get property methods
            public string GetCategory()
            {
                return memeCategory.get_hash();
            }
            public string GetPath()
            {
                return memeImg.GetPath();
            }
            public string GetTitle()
            {
                return this.title;
            }
            public Int32[] GetSize()
            {
                return memeImg.GetSize();
            }
            public void VoteUp(){
                votes+=1;
            }

        }
}