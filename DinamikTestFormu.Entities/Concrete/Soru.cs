﻿using System;
using System.Collections.Generic;
using DinamikTestFormu.Entities.Concrete.Base;

namespace DinamikTestFormu.Entities.Concrete
{
    public class Soru: EntityBase
    {
        public byte[] Gorsel { get; set; }
        public string Metin { get; set; }

        public Guid? DersId { get; set; }
        public virtual Ders Ders { get; set; }

        public Guid? DogruSecenekId { get; set; }
        public virtual Secenek Secenek { get; set; }

        public virtual ICollection<Secenek> Secenekler { get; set; }
        public virtual ICollection<SinavSoru> SinavSorulari { get; set; }
    }
}