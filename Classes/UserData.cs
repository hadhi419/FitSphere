using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitSphere.Classes
{
    [FirestoreData]
    public class UserData
    {
        [FirestoreProperty]
        public String Username { get; set; }

        [FirestoreProperty]
        public String Password { get; set; }

        [FirestoreProperty]
        public String Email { get; set; }
    }
}
