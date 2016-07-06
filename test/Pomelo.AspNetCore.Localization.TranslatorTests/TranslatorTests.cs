﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Pomelo.AspNetCore.Localization;

namespace Pomelo.AspNetCore.Localization.TranslatorTests
{
    public class TranslatorTests
    {
        [Fact]
        public async void google_translator_test()
        {
            var translator = new GoogleTranslator();
            var result = await translator.TranslateAsync("en", "zh", "Hello");
            Assert.Equal("你好", result);
        }
    }
}