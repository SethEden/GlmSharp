using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_bvec3
    {
        public readonly bool x;
        public readonly bool y;
        public readonly bool z;
        
        public swizzle_bvec3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        public bvec2 xx => new bvec2(x, x);
        public bvec3 xxx => new bvec3(x, x, x);
        public bvec4 xxxx => new bvec4(x, x, x, x);
        public bvec4 xxxy => new bvec4(x, x, x, y);
        public bvec4 xxxz => new bvec4(x, x, x, z);
        public bvec3 xxy => new bvec3(x, x, y);
        public bvec4 xxyx => new bvec4(x, x, y, x);
        public bvec4 xxyy => new bvec4(x, x, y, y);
        public bvec4 xxyz => new bvec4(x, x, y, z);
        public bvec3 xxz => new bvec3(x, x, z);
        public bvec4 xxzx => new bvec4(x, x, z, x);
        public bvec4 xxzy => new bvec4(x, x, z, y);
        public bvec4 xxzz => new bvec4(x, x, z, z);
        public bvec2 xy => new bvec2(x, y);
        public bvec3 xyx => new bvec3(x, y, x);
        public bvec4 xyxx => new bvec4(x, y, x, x);
        public bvec4 xyxy => new bvec4(x, y, x, y);
        public bvec4 xyxz => new bvec4(x, y, x, z);
        public bvec3 xyy => new bvec3(x, y, y);
        public bvec4 xyyx => new bvec4(x, y, y, x);
        public bvec4 xyyy => new bvec4(x, y, y, y);
        public bvec4 xyyz => new bvec4(x, y, y, z);
        public bvec3 xyz => new bvec3(x, y, z);
        public bvec4 xyzx => new bvec4(x, y, z, x);
        public bvec4 xyzy => new bvec4(x, y, z, y);
        public bvec4 xyzz => new bvec4(x, y, z, z);
        public bvec2 xz => new bvec2(x, z);
        public bvec3 xzx => new bvec3(x, z, x);
        public bvec4 xzxx => new bvec4(x, z, x, x);
        public bvec4 xzxy => new bvec4(x, z, x, y);
        public bvec4 xzxz => new bvec4(x, z, x, z);
        public bvec3 xzy => new bvec3(x, z, y);
        public bvec4 xzyx => new bvec4(x, z, y, x);
        public bvec4 xzyy => new bvec4(x, z, y, y);
        public bvec4 xzyz => new bvec4(x, z, y, z);
        public bvec3 xzz => new bvec3(x, z, z);
        public bvec4 xzzx => new bvec4(x, z, z, x);
        public bvec4 xzzy => new bvec4(x, z, z, y);
        public bvec4 xzzz => new bvec4(x, z, z, z);
        public bvec2 yx => new bvec2(y, x);
        public bvec3 yxx => new bvec3(y, x, x);
        public bvec4 yxxx => new bvec4(y, x, x, x);
        public bvec4 yxxy => new bvec4(y, x, x, y);
        public bvec4 yxxz => new bvec4(y, x, x, z);
        public bvec3 yxy => new bvec3(y, x, y);
        public bvec4 yxyx => new bvec4(y, x, y, x);
        public bvec4 yxyy => new bvec4(y, x, y, y);
        public bvec4 yxyz => new bvec4(y, x, y, z);
        public bvec3 yxz => new bvec3(y, x, z);
        public bvec4 yxzx => new bvec4(y, x, z, x);
        public bvec4 yxzy => new bvec4(y, x, z, y);
        public bvec4 yxzz => new bvec4(y, x, z, z);
        public bvec2 yy => new bvec2(y, y);
        public bvec3 yyx => new bvec3(y, y, x);
        public bvec4 yyxx => new bvec4(y, y, x, x);
        public bvec4 yyxy => new bvec4(y, y, x, y);
        public bvec4 yyxz => new bvec4(y, y, x, z);
        public bvec3 yyy => new bvec3(y, y, y);
        public bvec4 yyyx => new bvec4(y, y, y, x);
        public bvec4 yyyy => new bvec4(y, y, y, y);
        public bvec4 yyyz => new bvec4(y, y, y, z);
        public bvec3 yyz => new bvec3(y, y, z);
        public bvec4 yyzx => new bvec4(y, y, z, x);
        public bvec4 yyzy => new bvec4(y, y, z, y);
        public bvec4 yyzz => new bvec4(y, y, z, z);
        public bvec2 yz => new bvec2(y, z);
        public bvec3 yzx => new bvec3(y, z, x);
        public bvec4 yzxx => new bvec4(y, z, x, x);
        public bvec4 yzxy => new bvec4(y, z, x, y);
        public bvec4 yzxz => new bvec4(y, z, x, z);
        public bvec3 yzy => new bvec3(y, z, y);
        public bvec4 yzyx => new bvec4(y, z, y, x);
        public bvec4 yzyy => new bvec4(y, z, y, y);
        public bvec4 yzyz => new bvec4(y, z, y, z);
        public bvec3 yzz => new bvec3(y, z, z);
        public bvec4 yzzx => new bvec4(y, z, z, x);
        public bvec4 yzzy => new bvec4(y, z, z, y);
        public bvec4 yzzz => new bvec4(y, z, z, z);
        public bvec2 zx => new bvec2(z, x);
        public bvec3 zxx => new bvec3(z, x, x);
        public bvec4 zxxx => new bvec4(z, x, x, x);
        public bvec4 zxxy => new bvec4(z, x, x, y);
        public bvec4 zxxz => new bvec4(z, x, x, z);
        public bvec3 zxy => new bvec3(z, x, y);
        public bvec4 zxyx => new bvec4(z, x, y, x);
        public bvec4 zxyy => new bvec4(z, x, y, y);
        public bvec4 zxyz => new bvec4(z, x, y, z);
        public bvec3 zxz => new bvec3(z, x, z);
        public bvec4 zxzx => new bvec4(z, x, z, x);
        public bvec4 zxzy => new bvec4(z, x, z, y);
        public bvec4 zxzz => new bvec4(z, x, z, z);
        public bvec2 zy => new bvec2(z, y);
        public bvec3 zyx => new bvec3(z, y, x);
        public bvec4 zyxx => new bvec4(z, y, x, x);
        public bvec4 zyxy => new bvec4(z, y, x, y);
        public bvec4 zyxz => new bvec4(z, y, x, z);
        public bvec3 zyy => new bvec3(z, y, y);
        public bvec4 zyyx => new bvec4(z, y, y, x);
        public bvec4 zyyy => new bvec4(z, y, y, y);
        public bvec4 zyyz => new bvec4(z, y, y, z);
        public bvec3 zyz => new bvec3(z, y, z);
        public bvec4 zyzx => new bvec4(z, y, z, x);
        public bvec4 zyzy => new bvec4(z, y, z, y);
        public bvec4 zyzz => new bvec4(z, y, z, z);
        public bvec2 zz => new bvec2(z, z);
        public bvec3 zzx => new bvec3(z, z, x);
        public bvec4 zzxx => new bvec4(z, z, x, x);
        public bvec4 zzxy => new bvec4(z, z, x, y);
        public bvec4 zzxz => new bvec4(z, z, x, z);
        public bvec3 zzy => new bvec3(z, z, y);
        public bvec4 zzyx => new bvec4(z, z, y, x);
        public bvec4 zzyy => new bvec4(z, z, y, y);
        public bvec4 zzyz => new bvec4(z, z, y, z);
        public bvec3 zzz => new bvec3(z, z, z);
        public bvec4 zzzx => new bvec4(z, z, z, x);
        public bvec4 zzzy => new bvec4(z, z, z, y);
        public bvec4 zzzz => new bvec4(z, z, z, z);
        
        // RGBA Versions
        public bvec2 rr => new bvec2(x, x);
        public bvec3 rrr => new bvec3(x, x, x);
        public bvec4 rrrr => new bvec4(x, x, x, x);
        public bvec4 rrrg => new bvec4(x, x, x, y);
        public bvec4 rrrb => new bvec4(x, x, x, z);
        public bvec3 rrg => new bvec3(x, x, y);
        public bvec4 rrgr => new bvec4(x, x, y, x);
        public bvec4 rrgg => new bvec4(x, x, y, y);
        public bvec4 rrgb => new bvec4(x, x, y, z);
        public bvec3 rrb => new bvec3(x, x, z);
        public bvec4 rrbr => new bvec4(x, x, z, x);
        public bvec4 rrbg => new bvec4(x, x, z, y);
        public bvec4 rrbb => new bvec4(x, x, z, z);
        public bvec2 rg => new bvec2(x, y);
        public bvec3 rgr => new bvec3(x, y, x);
        public bvec4 rgrr => new bvec4(x, y, x, x);
        public bvec4 rgrg => new bvec4(x, y, x, y);
        public bvec4 rgrb => new bvec4(x, y, x, z);
        public bvec3 rgg => new bvec3(x, y, y);
        public bvec4 rggr => new bvec4(x, y, y, x);
        public bvec4 rggg => new bvec4(x, y, y, y);
        public bvec4 rggb => new bvec4(x, y, y, z);
        public bvec3 rgb => new bvec3(x, y, z);
        public bvec4 rgbr => new bvec4(x, y, z, x);
        public bvec4 rgbg => new bvec4(x, y, z, y);
        public bvec4 rgbb => new bvec4(x, y, z, z);
        public bvec2 rb => new bvec2(x, z);
        public bvec3 rbr => new bvec3(x, z, x);
        public bvec4 rbrr => new bvec4(x, z, x, x);
        public bvec4 rbrg => new bvec4(x, z, x, y);
        public bvec4 rbrb => new bvec4(x, z, x, z);
        public bvec3 rbg => new bvec3(x, z, y);
        public bvec4 rbgr => new bvec4(x, z, y, x);
        public bvec4 rbgg => new bvec4(x, z, y, y);
        public bvec4 rbgb => new bvec4(x, z, y, z);
        public bvec3 rbb => new bvec3(x, z, z);
        public bvec4 rbbr => new bvec4(x, z, z, x);
        public bvec4 rbbg => new bvec4(x, z, z, y);
        public bvec4 rbbb => new bvec4(x, z, z, z);
        public bvec2 gr => new bvec2(y, x);
        public bvec3 grr => new bvec3(y, x, x);
        public bvec4 grrr => new bvec4(y, x, x, x);
        public bvec4 grrg => new bvec4(y, x, x, y);
        public bvec4 grrb => new bvec4(y, x, x, z);
        public bvec3 grg => new bvec3(y, x, y);
        public bvec4 grgr => new bvec4(y, x, y, x);
        public bvec4 grgg => new bvec4(y, x, y, y);
        public bvec4 grgb => new bvec4(y, x, y, z);
        public bvec3 grb => new bvec3(y, x, z);
        public bvec4 grbr => new bvec4(y, x, z, x);
        public bvec4 grbg => new bvec4(y, x, z, y);
        public bvec4 grbb => new bvec4(y, x, z, z);
        public bvec2 gg => new bvec2(y, y);
        public bvec3 ggr => new bvec3(y, y, x);
        public bvec4 ggrr => new bvec4(y, y, x, x);
        public bvec4 ggrg => new bvec4(y, y, x, y);
        public bvec4 ggrb => new bvec4(y, y, x, z);
        public bvec3 ggg => new bvec3(y, y, y);
        public bvec4 gggr => new bvec4(y, y, y, x);
        public bvec4 gggg => new bvec4(y, y, y, y);
        public bvec4 gggb => new bvec4(y, y, y, z);
        public bvec3 ggb => new bvec3(y, y, z);
        public bvec4 ggbr => new bvec4(y, y, z, x);
        public bvec4 ggbg => new bvec4(y, y, z, y);
        public bvec4 ggbb => new bvec4(y, y, z, z);
        public bvec2 gb => new bvec2(y, z);
        public bvec3 gbr => new bvec3(y, z, x);
        public bvec4 gbrr => new bvec4(y, z, x, x);
        public bvec4 gbrg => new bvec4(y, z, x, y);
        public bvec4 gbrb => new bvec4(y, z, x, z);
        public bvec3 gbg => new bvec3(y, z, y);
        public bvec4 gbgr => new bvec4(y, z, y, x);
        public bvec4 gbgg => new bvec4(y, z, y, y);
        public bvec4 gbgb => new bvec4(y, z, y, z);
        public bvec3 gbb => new bvec3(y, z, z);
        public bvec4 gbbr => new bvec4(y, z, z, x);
        public bvec4 gbbg => new bvec4(y, z, z, y);
        public bvec4 gbbb => new bvec4(y, z, z, z);
        public bvec2 br => new bvec2(z, x);
        public bvec3 brr => new bvec3(z, x, x);
        public bvec4 brrr => new bvec4(z, x, x, x);
        public bvec4 brrg => new bvec4(z, x, x, y);
        public bvec4 brrb => new bvec4(z, x, x, z);
        public bvec3 brg => new bvec3(z, x, y);
        public bvec4 brgr => new bvec4(z, x, y, x);
        public bvec4 brgg => new bvec4(z, x, y, y);
        public bvec4 brgb => new bvec4(z, x, y, z);
        public bvec3 brb => new bvec3(z, x, z);
        public bvec4 brbr => new bvec4(z, x, z, x);
        public bvec4 brbg => new bvec4(z, x, z, y);
        public bvec4 brbb => new bvec4(z, x, z, z);
        public bvec2 bg => new bvec2(z, y);
        public bvec3 bgr => new bvec3(z, y, x);
        public bvec4 bgrr => new bvec4(z, y, x, x);
        public bvec4 bgrg => new bvec4(z, y, x, y);
        public bvec4 bgrb => new bvec4(z, y, x, z);
        public bvec3 bgg => new bvec3(z, y, y);
        public bvec4 bggr => new bvec4(z, y, y, x);
        public bvec4 bggg => new bvec4(z, y, y, y);
        public bvec4 bggb => new bvec4(z, y, y, z);
        public bvec3 bgb => new bvec3(z, y, z);
        public bvec4 bgbr => new bvec4(z, y, z, x);
        public bvec4 bgbg => new bvec4(z, y, z, y);
        public bvec4 bgbb => new bvec4(z, y, z, z);
        public bvec2 bb => new bvec2(z, z);
        public bvec3 bbr => new bvec3(z, z, x);
        public bvec4 bbrr => new bvec4(z, z, x, x);
        public bvec4 bbrg => new bvec4(z, z, x, y);
        public bvec4 bbrb => new bvec4(z, z, x, z);
        public bvec3 bbg => new bvec3(z, z, y);
        public bvec4 bbgr => new bvec4(z, z, y, x);
        public bvec4 bbgg => new bvec4(z, z, y, y);
        public bvec4 bbgb => new bvec4(z, z, y, z);
        public bvec3 bbb => new bvec3(z, z, z);
        public bvec4 bbbr => new bvec4(z, z, z, x);
        public bvec4 bbbg => new bvec4(z, z, z, y);
        public bvec4 bbbb => new bvec4(z, z, z, z);
    }
}