﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMed3.Classes
{
    public class Patologia
    {
        string codicePatologia, nome, descrizione;

        public Patologia()
        {
            this.codicePatologia = this.nome = this.descrizione = "";
        }

        public Patologia(string codicePatologia, string nome, string descrizione)
        {
            this.codicePatologia = codicePatologia;
            this.nome = nome;
            this.descrizione = descrizione;
        }

        public Patologia(string codicePatologia)
        {
            this.codicePatologia = codicePatologia;
            this.nome = null;
            this.descrizione = null;
        }

        public string CodicePatologia
        {
            get
            {
                return codicePatologia;
            }

            set
            {
                codicePatologia = value;
            }
        }

        public string Descrizione
        {
            get
            {
                return descrizione;
            }

            set
            {
                descrizione = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
