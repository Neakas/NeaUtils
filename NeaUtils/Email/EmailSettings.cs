namespace NeaUtils.Email
{
    public class EmailSettings
    {
        public string Benutzername { get; set; }
        public string SmtpServer { get; set; }
        public string Domain { get; set; }
        public string Absender { get; set; }
        public string Passwort { get; set; }
        public bool SslVerschlüsselung { get; set; }

        public string[] Assemblies { get; set; }


        public EmailSettings(string benutzername, string smtpserver, string domain, string absender, bool sslverschlüsselung = false, string passwort = "passwort")
        {
            Benutzername = benutzername;
            Passwort = passwort;
            SmtpServer = smtpserver;
            Domain = domain;
            Absender = absender;
            SslVerschlüsselung = sslverschlüsselung;
        }
    }
}
