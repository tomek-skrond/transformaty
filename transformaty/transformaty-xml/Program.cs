using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Linq;

namespace transformaty_xml
{
    class Program
    {
        public static List<string> GetTreeContents()
        {

        }
        public static XElement ConstructTree(List<string> treeContents)
        {
            var counter = 0;
            return new XElement("dokumenty",
                        new XElement("faktura",
                            new XElement("kontrahentAdres1",treeContents[counter++])));
        }

            
        static void Main(string[] args)
        {
            
        }
    }
}
