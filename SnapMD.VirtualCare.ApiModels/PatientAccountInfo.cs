﻿#region Copyright
//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion
namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represents patient details for administrator patient lists.
    /// </summary>
    public class PatientAccountInfo
    {
        public int PatientId { get; set; }
        public int? UserId { get; set; }
        public string ProfileImagePath { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public bool IsAuthorized { get; set; }
        public PatientAccountStatus Status { get; set; }
        public bool IsDependent { get; set; }
        public int? GuardianId { get; set; }
        public string Email { get; set; }
    }
}
