using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arvoresbinarias
{
    public class treenode<T>
    {
        public T Data {get; set;}
        public treenode<T> parent {get; set;}
        public list<treenode<T>> Children {get;set;} =[];

        public int GetHeit ()
        {
            int height = 1;
            treenode<T> current = this;
            while(current.parent != null)
            {
                height++;
                current = current.parent;

            } 
            return height;


        }
    }
}