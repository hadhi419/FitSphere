using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitSphere.Classes
{
    [FirestoreData]
    public class MyRecipe
    {
        
            [FirestoreProperty]
            public String RecipeName { get; set; }

            [FirestoreProperty]
            public String Description { get; set; }

            [FirestoreProperty]
            public String Ingredients { get; set; }

            [FirestoreProperty]
            public String Directions { get; set; }
            
            [FirestoreProperty]
            public String Email { get; set; }



    }
}
