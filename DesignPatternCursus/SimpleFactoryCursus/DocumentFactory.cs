using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryCursus
{
    public class DocumentFactory
    {
        private static DocumentFactory _uniekeFactory;
        private DocumentFactory() { }
        public static DocumentFactory GetInstance()
        {
            if(_uniekeFactory == null)
            {
                _uniekeFactory = new DocumentFactory();
            }
            return _uniekeFactory;
        }
        public Document Open(string bestandsnaam)
        {
            string extensie = bestandsnaam.Substring(bestandsnaam.Length - 4);
            switch(extensie)
            {
                case "docx":
                    return new Tekst(bestandsnaam);
                case "xlsx":
                    return new Rekenblad(bestandsnaam);
                case "pptx":
                    return new Presentatie(bestandsnaam);
                default:
                    throw new Exception("Verkeerde extensie.");
            }
        }
    }
}
