﻿using SSOA.Services.Seo;
using SSOA.Tests;
using NUnit.Framework;

namespace SSOA.Services.Tests.Seo
{
    [TestFixture]
    public class SeoExtensionsTests
    {
        [Test]
        public void Should_return_lowercase()
        {
            SeoExtensions.GetSeName("tEsT", false, false).ShouldEqual("test");
        }

        [Test]
        public void Should_allow_all_latin_chars()
        {
            SeoExtensions.GetSeName("abcdefghijklmSSOAqrstuvwxyz1234567890", false, false).ShouldEqual("abcdefghijklmSSOAqrstuvwxyz1234567890");
        }

        [Test]
        public void Should_remove_illegal_chars()
        {
            SeoExtensions.GetSeName("test!@#$%^&*()+<>?/", false, false).ShouldEqual("test");
        }

        [Test]
        public void Should_replace_space_with_dash()
        {
            SeoExtensions.GetSeName("test test", false, false).ShouldEqual("test-test");
            SeoExtensions.GetSeName("test     test", false, false).ShouldEqual("test-test");
        }

        [Test]
        public void Can_convert_non_western_chars()
        {
            //german letters with diacritics
            SeoExtensions.GetSeName("testäöü", true, false).ShouldEqual("testaou");
            SeoExtensions.GetSeName("testäöü", false, false).ShouldEqual("test");
        }

        [Test]
        public void Can_allow_unicode_chars()
        {
            //russian letters
            SeoExtensions.GetSeName("testтест", false, true).ShouldEqual("testтест");
            SeoExtensions.GetSeName("testтест", false, false).ShouldEqual("test");
        }
    }
}



