using Xunit;

namespace net.r_eg.algorithms.Tests
{
    public class HashValues
    {
        [Theory]
        [InlineData("Hello World!", 0xd2d42892ede87203, 0x1d2593366229c2d2)]
        [InlineData("Hello world!", 0x3c94fff9ede87203, 0x1d95566a45770eb2)]
        [InlineData("Hello world",  0x3e2069a3a2839515, 0xf3e747cab303a0d7)]
        [InlineData("Hello world ", 0x3c94fff9eee87203, 0x1d95566a45770fed)]
        [InlineData("Fnv1a128", 0xc13dd8c55a659aa1, 0x1f912cfd85b8ed7c)]
        [InlineData("github/3F", 0x506f2e1fb3060b4c, 0x8d3110e8b4e77e16)]
        [InlineData("LX4Cnh", 0x27348aa3e13c64bf, 0x6e7a25d900f385aa)]
        [InlineData("", 0x6c62272e07bb0142, 0x62b821756295c58d)]
        [InlineData(" ", 0xd228cb69301a8caf, 0x78912b704e4a3bdf)]
        [InlineData("  ", 0x088094aa2fab1be9, 0x5aa073305557d2c5)]
        [InlineData("Password123", 0x8d9e9ae9fd9b0356, 0xdfe55ca4bb8cb938)]
        [InlineData("7", 0xd228cb693d1a8caf, 0x78912b704e4a4bde)]
        [InlineData("'", 0xd228cb692d1a8caf, 0x78912b704e4a382e)]
        [InlineData("1234", 0x680bc8ef6e757277, 0xb806e9090df65bc5)]
        [InlineData("123456", 0x48295155463c64bf, 0x6e69f684c538dd82)]
        [InlineData("123456789", 0xda2d42a08d04e458, 0x5dd325117f71d504)]
        [InlineData("root", 0x69fe44a65b757277, 0xb806e9a25079adf5)]
        [InlineData("Root", 0x690eaab55b757277, 0xb806e9587de03515)]
        [InlineData("admin", 0x324a6bd28d83d94f, 0x7081447a94746b34)]
        [InlineData("admin123", 0x96f15ba8e1659b4d, 0x72266ffb9ebc728c)]
        [InlineData("https://github.com/3F/Fnv1a128", 0x43d00056982fd53c, 0x44f663dd27c6742a)]
        [InlineData("✔", 0xd228cb861c1a8caf, 0x78912b704e6dd243)]
        public void EqTest1(string input, ulong high, ulong low)
        {
            Assert.Equal(high, Fnv1a.GetHash128LX4Cnh(input, out ulong l));
            Assert.Equal(low, l);
        }
    }
}
