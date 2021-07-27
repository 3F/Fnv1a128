using System;
using Xunit;

namespace net.r_eg.algorithms.Tests
{
    public class HashValues
    {
        [Fact]
        public void Test1()
        {
            const string _MSG = "*LodgeX4CorrNoHigh* (LX4Cnh) algorithm of the high-speed multiplications of **128-bit** numbers (full range, 128 × 128).";

            Assert.Equal
            (
                Fnv1a.GetHash128Call(_MSG, out ulong low1),
                Fnv1a.GetHash128LX4Cnh(_MSG, out ulong low2)
            );
            Assert.Equal(low1, low2);
        }

        [Fact]
        public void Test2()
        {
            for(int i = 0; i < 1000; ++i)
            {
                string msg = $"LodgeX4CorrNoHigh (LX4Cnh) for {System.Guid.NewGuid()}";

                Assert.Equal
                (
                    Fnv1a.GetHash128Call(msg, out ulong low1),
                    Fnv1a.GetHash128LX4Cnh(msg, out ulong low2)
                );
                Assert.Equal(low1, low2);
            }
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(Fnv1a.OFS128_H, Fnv1a.GetHash128LX4Cnh(string.Empty, out ulong low));
            Assert.Equal(Fnv1a.OFS128_L, low);
        }

        [Fact]
        public void Test4()
        {
            Assert.Throws<ArgumentNullException>(() => Fnv1a.GetHash128LX4Cnh(null, out ulong low));
        }
    }
}
