﻿using System.Collections.Generic;

namespace Anabi.DataAccess.Ef.DbModels
{
    public class DecizieDb
    {
        public int Id { get; set; }

        public string Denumire { get; set; }

        public virtual ICollection<EtapePentruDecizieDb> EtapePosibile { get; set; }

        

    }
}