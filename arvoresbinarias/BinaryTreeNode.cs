using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arvoresbinarias
{
    public class BYNARYTREENODE<T> : treenode<T>
    {  /*
        public BYNARYTREENODE() =>
         Children = new list<treenode<T>> (){
            null, null
        };
      */
      public BYNARYTREENODE()
      {
        Children = new list<BYNARYTREENODE<Tesk>>();
        Children.add(null);
        Children.add(null);

      }  
    }
}