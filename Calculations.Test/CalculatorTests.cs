using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    public class CalculatorTests
    {
        [Fact]
        [Trait("Category","Number")]
        public void Add_GivenTwoIntValues_ReturnInt()
        {
            int result = Calcolator.Add(1,2);
            Assert.Equal(3, result);
        }
        [Fact]
        [Trait("Category","Number")]
        public void AddDouble_GivenTwoDoubleValues_ReturnDouble()
        {
            double result = Calcolator.AddDouble(1.2,3.5);
            Assert.Equal(4.7,result);
        }
        [Fact]
        [Trait("Category","String")]
        public void MakeFullName_GivenNameAndSurname_ReturnFullName()
        {
            var calc = new Calcolator();
            string result = calc.MakeFullName("Mehmet","Teker");
            //Assert.Equal("Mehmet Teker",result, ignoreCase:true);
            Assert.Contains("Mehmet", result,StringComparison.InvariantCultureIgnoreCase);
            //Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result); 
            /* 
               Regex bir string ifadenin (metin) belirli kurallara uyumluluğunu kontrol etmeye ve düzenlemeye yarar.
               Açılımı Regular Expressions, Türkçesi ise Düzenli İfadeler olarak geçer.
            */
        }
        [Fact]
        [Trait("Category","String")]
        public void NickName_MustBeNull()
        {
            var calc = new Calcolator();
            calc.NickName = "Strong Man";
            Assert.NotNull(calc.NickName);
        }
        [Fact]
        [Trait("Category","String")]
        public void MakeFullName_AlwaysReturnValues()
        {
            var calc = new Calcolator();
            string result = calc.MakeFullName("Mehmet","Teker");
            Assert.True(!string.IsNullOrEmpty(result));
        }

    }
}
