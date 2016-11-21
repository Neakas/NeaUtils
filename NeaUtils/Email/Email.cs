namespace NeaUtils.Email
{
    public class Email
    {
        public string[] Empfänger { get; set; }
        public string Betreff { get; set; }
        public string Mailtext { get; set; }
        public string[] Anhänge { get; set; }
        public string[] CcEmpfänger { get; set; }
        public string[] BccEmpfänger { get; set; }

        /// <summary>
        /// Versand einer Email über Smtp
        /// </summary>
        /// <param name="empfänger">Die empfänger Adresse</param>
        /// <param name="betreff">Der betreff</param>
        /// <param name="mailtext">Der mailtext; Supportet HTML</param>
        /// <param name="anhänge">Die Dateipfade der Dateien die angehangen werden sollen</param>
        public Email(string empfänger, string betreff, string mailtext, string[] anhänge = null)
        {
            Empfänger[0] = empfänger;
            Betreff = betreff;
            Mailtext = mailtext;
            Anhänge = anhänge;
        }

        public Email(string[] empfängerliste, string betreff, string mailtext, string[] anhänge = null)
        {
            Empfänger = empfängerliste;
            Betreff = betreff;
            Mailtext = mailtext;
            Anhänge = anhänge;
        }

        public Email(string[] empfängerliste, string betreff, string mailtext, string[] ccempfänger,
                     string[] bccempfänger, string[] anhänge = null)
        {
            Empfänger = empfängerliste;
            Betreff = betreff;
            Mailtext = mailtext;
            Anhänge = anhänge;
            CcEmpfänger = ccempfänger;
            BccEmpfänger = bccempfänger;
        }
    }
}
