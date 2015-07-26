﻿using FluentValidation.TestHelper;
using SSOA.Core.Domain.Common;
using SSOA.Web.Models.Common;
using SSOA.Web.Validators.Common;
using NUnit.Framework;

namespace SSOA.Web.MVC.Tests.Public.Validators.Common
{
    [TestFixture]
    public class ContactUsValidatorTests : BaseValidatorTests
    {
        private ContactUsValidator _validator;
        private CommonSettings _commonSettings;
        
        [SetUp]
        public new void Setup()
        {
            _commonSettings = new CommonSettings();
            _validator = new ContactUsValidator(_localizationService, _commonSettings);
        }
        
        [Test]
        public void Should_have_error_when_email_is_null_or_empty()
        {
            var model = new ContactUsModel();
            model.Email = null;
            _validator.ShouldHaveValidationErrorFor(x => x.Email, model);
            model.Email = "";
            _validator.ShouldHaveValidationErrorFor(x => x.Email, model);
        }

        [Test]
        public void Should_have_error_when_email_is_wrong_format()
        {
            var model = new ContactUsModel();
            model.Email = "adminexample.com";
            _validator.ShouldHaveValidationErrorFor(x => x.Email, model);
        }

        [Test]
        public void Should_not_have_error_when_email_is_correct_format()
        {
            var model = new ContactUsModel();
            model.Email = "admin@example.com";
            _validator.ShouldNotHaveValidationErrorFor(x => x.Email, model);
        }

        [Test]
        public void Should_have_error_when_fullName_is_null_or_empty()
        {
            var model = new ContactUsModel();
            model.FullName = null;
            _validator.ShouldHaveValidationErrorFor(x => x.FullName, model);
            model.FullName = "";
            _validator.ShouldHaveValidationErrorFor(x => x.FullName, model);
        }

        [Test]
        public void Should_not_have_error_when_fullName_is_specified()
        {
            var model = new ContactUsModel();
            model.FullName = "John Smith";
            _validator.ShouldNotHaveValidationErrorFor(x => x.FullName, model);
        }

        [Test]
        public void Should_have_error_when_enquiry_is_null_or_empty()
        {
            var model = new ContactUsModel();
            model.Enquiry = null;
            _validator.ShouldHaveValidationErrorFor(x => x.Enquiry, model);
            model.Enquiry = "";
            _validator.ShouldHaveValidationErrorFor(x => x.Enquiry, model);
        }

        [Test]
        public void Should_not_have_error_when_enquiry_is_specified()
        {
            var model = new ContactUsModel();
            model.Enquiry = "please call me back";
            _validator.ShouldNotHaveValidationErrorFor(x => x.Enquiry, model);
        }
    }
}
