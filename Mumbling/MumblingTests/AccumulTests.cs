using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mumbling;

namespace MumblingTests
{
    [TestClass]
    public class AccumulTests
    {
        [TestMethod]
        public void Accum_Tests ()
        {
            Assert.AreEqual("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu", Acumul.Accum("ZpglnRxqenU"));
            Assert.AreEqual("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb", Acumul.Accum("NyffsGeyylB"));
            Assert.AreEqual("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu", Acumul.Accum("MjtkuBovqrU"));
            Assert.AreEqual("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm", Acumul.Accum("EvidjUnokmM"));
            Assert.AreEqual("H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc", Acumul.Accum("HbideVbxncC"));
        }
    }
}
