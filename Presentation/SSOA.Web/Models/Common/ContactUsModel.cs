﻿using System.Web.Mvc;
using FluentValidation.Attributes;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;
using SSOA.Web.Validators.Common;

namespace SSOA.Web.Models.Common
{
    [Validator(typeof(ContactUsValidator))]
    public partial class ContactUsModel : BaseSSOAModel
    {
        [AllowHtml]
        [SSOAResourceDisplayName("ContactUs.Email")]
        public string Email { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactUs.Subject")]
        public string Subject { get; set; }
        public bool SubjectEnabled { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactUs.Enquiry")]
        public string Enquiry { get; set; }

        [AllowHtml]
        [SSOAResourceDisplayName("ContactUs.FullName")]
        public string FullName { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}