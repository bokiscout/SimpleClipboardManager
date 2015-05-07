using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace VP_Proekt_ClipboardManager
{
    public class myStringColection : StringCollection
    {
        private StringCollection item;

        public myStringColection(StringCollection item)
        {
            this.item = item;
        }
       
        public override bool Equals(object obj)
        {
            StringCollection sc = obj as StringCollection;
            if (item.Count != sc.Count)
            {
                return false;
            }
            else
            {
                for(int i = 0; i < item.Count; i++){
                    string itemString = item[i].ToString();
                    string scString = sc[i].ToString();
                    
                    if(itemString.CompareTo(scString) == 0){
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
