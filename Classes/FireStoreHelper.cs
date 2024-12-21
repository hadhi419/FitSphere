using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitSphere.Classes
{
    internal static class FireStoreHelper
    {
        static String fireConfig = @"
            {
  ""type"": ""service_account"",
  ""project_id"": ""fitsphere-cb3d8"",
  ""private_key_id"": ""a306d5cdb8e8bf0f2e39b06d7ec9701952b36179"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDjaT7/nhTWSXku\nBH0/xR4vi36Cuozx1MVaS54T+wfIoHslt7N6ACvlDf20wv9yNRMB48CYuq5syJaU\nnEq5+W/2mMD/8hgvwGgYmgYtkgpGyQgLaXI6bI0fhwaPxCtJuqyDcpNy8nQ73X+x\n+5UDumMBD2wJIMiBtMxj3OqGETqSmMMUVQuqOEVY0uPlbBrGSUpe7pzx/Kv0lKQ/\nazPVYHnYqnPm1LKxQYezkLbqlvv1OprUM4WpH/fWva0cXQ8h9FW3IFy76BOiIx6Z\nW5xgJ4W+3CN7JiZOwsVqPOA4T8UOIsolYwDAL8fEE5wjxqnDdoWdtKXDbpgWIwnj\nXW6HYJZRAgMBAAECggEAAxTR/bSuo5irQ6xb5hlNp2dEd5D/h+dSJT8RDURBfr5t\n7Lzoeaa28YuW/HQH8gw2DbiAS5F7+41cPPdBK/PtSHIZa15kZYE959dubf+klAD1\nUvJC0ffWka7Kr/gAfidBXyaWSOBwIr+Fk2vNQRetb749wIHpNZi1jETaCKcDHClf\nMMfyZY6SAcTduE9Y1tbt9ogPDe0dOkx2EQv+hoLTego2or5pWHmMrtKC4DJS1Nr3\nCKS+9zhtr7Qj0+/vu0gB/DREVUVw+QjfKX0xd46rPvPv3So+rJNxqOWgfa8ho+CJ\nbOG/rdMpaKtJKmNPmQHweOnVQF2VlWEEQ3uCPSFa4QKBgQD4AHt88ZcgTaetkakT\nJSKh4tKm6OI4VYhTenFdmnzwFENJpsCtr0/wktFYxoCeXl3qmptY8S1jXrayuy3e\nZbCnwxbbliS/eaWn1CwsYx5cLyzzfSzXV3TTMuW1JJcciTGErHlURAGHoVysEhPV\n4XLJlMaVygNwqQ42P633wWuK1wKBgQDqvsPid8Yr3V4ZKMmeD+udr2sSSsjSWV88\nuygWFZkpzktLanFmMYqgPvY6xAenoLj4/IpzEhF0JHlGdymFJB+REDd5yP/MhoRT\nfr2ThRGUVkMh1iiiVUCd8Az3Yj6ebUB2ph+11U7CfZ0KG/CGh6Ai/wpEYrDvOHCa\n/bJtXSMrFwKBgQDX1DukCfCW6V4THOACzF+ueWMQZT5y/mUNGVNNveQbX9cLYvbu\ncNLmMC/GzcIjkUa0pGar6gCxKT1goKuTj/ZEmfDrm2hRxwFW5LyoyH4khd3d7cM3\niWIfZ30nvzdPW0pgB2Xz4tdd/R1UlsryaSjnq/WDaHLD+ixnI9Y39vmrswKBgC2O\nzldyZVx3/t4lI1PwxQp6U+5d4zGntKsFq5b1pB8P8V72joGF1eCZt5HaH54xvBRe\ndsQ0WnzO41aAo+c6BoJRwmJ5VuOrq5zEuSgbKDlAsJCtjn9Kylqcjven8n0uuNcO\nEJNqjXmDhWnD2F9TjQmds7Fn8ezLaFc8K1e8PqoLAoGAAO7TtN6sKD3yvWb0tVKL\nfE09vnoE+hBmauMia7YdnGuM8L1SGJjj2XAtswBe1xaQ9jvOiI5zjSs4hmXkUiqm\nYY6yxKFjfrkfpm7BGk7QC/VPnI7aW6Hsrz1AnAqJQxn2RRyBQhFVPo3xy7z5lJLk\na45uLlfbYILfGLQjWFQE9Ww=\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-r4l4r@fitsphere-cb3d8.iam.gserviceaccount.com"",
  ""client_id"": ""100695218724567451498"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-r4l4r%40fitsphere-cb3d8.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
            }";

        static String filePath = "";
        public static FirestoreDb? Database { get; private set; }


        public static void SetEnvironmentVariable()
        {
            filePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".jason";
            File.WriteAllText(filePath,fireConfig);
            File.SetAttributes(filePath, FileAttributes.Hidden); 
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS",filePath);
            Database = FirestoreDb.Create("fitsphere-cb3d8");
            File.Delete(filePath);
        }
    }
}
