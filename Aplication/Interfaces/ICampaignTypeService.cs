﻿using CRMSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface ICampaignTypeService
    {
        Task<List<CampaignTypes>> GetAll();
    }
}
