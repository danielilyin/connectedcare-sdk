﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class EmailInvitationRequest
    {
        public int? HospitalId { get; set; }

        public int? UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }
    }
}
