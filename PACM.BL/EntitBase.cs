﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntitBase
    {
        public EntityStateOption entityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid
        {
            get { return true; }
        }
    }
}