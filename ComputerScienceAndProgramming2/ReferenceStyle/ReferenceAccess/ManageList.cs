using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Cameron Davis 
//CS 1182
// manages all lists created of type Reference and puts them into a referenceable list.

namespace ReferenceAccess
{
    [Serializable()]
    public class ManageList 
    {        
        static List<Reference> myReferences = new List<Reference>();
        
        public static List<Reference> getReferenceList()
        {
            return myReferences;           
        }
        
        public static void setMyList(Reference reference)
        {           
            myReferences.Add(reference);
            myReferences.Sort();
        }
        public static void clearList()
        {
            myReferences.Clear();
        }
        
    }

   
}
