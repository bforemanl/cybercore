using System;
using System.Runtime.InteropServices;

namespace Cybercore.Native
{
    public static unsafe class LibMultihash
    {
        [DllImport("libmultihash", EntryPoint = "bcrypt_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void bcrypt(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "blake_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void blake(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "blake2s_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void blake2s(byte* input, void* output, uint inputLength, int outputLength = -1);

        [DllImport("libmultihash", EntryPoint = "blake2b_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void blake2b(byte* input, void* output, uint inputLength, int outputLength);

        [DllImport("libmultihash", EntryPoint = "c11_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void c11(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "cpupower_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void cpupower(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "dcrypt_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void dcrypt(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "fresh_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void fresh(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "fugue_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void fugue(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "geek_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void geek(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "groestl_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void groestl(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "groestl_myriad_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void groestl_myriad(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "hefty1_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void hefty1(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "heavyhash_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void heavyhash(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "jh_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void jh(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "keccak_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void keccak(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "minotaur_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void minotaur(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "neoscrypt_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void neoscrypt(byte* input, void* output, uint inputLength, uint profile);

        [DllImport("libmultihash", EntryPoint = "nist5_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void nist5(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "phi_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void phi(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "phi2_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void phi2(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "phi5_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void phi5(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "power2b_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void power2b(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "qubit_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void qubit(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "quark_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void quark(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "s3_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void s3(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "scrypt_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void scrypt(byte* input, void* output, uint n, uint r, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "scryptn_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void scryptn(byte* input, void* output, uint nFactor, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "shavite3_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void shavite3(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "skein_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void skein(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "verthash_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern int verthash(byte* input, void* output, int inputLength);

        [DllImport("libmultihash", EntryPoint = "verthash_init_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern int verthash_init(string filename, bool createIfMissing);

        [DllImport("libmultihash", EntryPoint = "verushash_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern int verushash(byte* input, void* output, int inputLength);

        [DllImport("libmultihash", EntryPoint = "x11_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x11(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x11evo_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x11evo(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x11k_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x11k(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x11kvs_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x11kvs(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x12_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x12(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x13_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x13(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x13_bcd_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x13_bcd(byte* input, void* output);

        [DllImport("libmultihash", EntryPoint = "x14_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x14(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x15_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x15(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x16r_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x16r(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x16rt_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x16rt(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x16rv2_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x16rv2(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x16s_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x16s(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x17_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x17(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x17r_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x17r(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x18_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x18(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x20r_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x20r(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x21s_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x21s(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x22_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x22(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x22i_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x22i(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "x25x_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void x25x(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yescrypt_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yescrypt(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yescryptR8_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yescryptR8(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yescryptR16_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yescryptR16(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yescryptR32_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yescryptR32(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_arwn_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_arwn(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_ic_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_ic(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_iots_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_iots(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_litb_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_litb(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_ltncg_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_ltncg(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_mgpc_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_mgpc(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_r16_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_r16(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_res_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_res(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_sugar_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_sugar(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_tide_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_tide(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "yespower_urx_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern void yespower_urx(byte* input, void* output, uint inputLength);

        [DllImport("libmultihash", EntryPoint = "equihash_verify_96_5_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool equihash_verify_96_5(byte* header, int headerLength, byte* solution, int solutionLength, string personalization);

        [DllImport("libmultihash", EntryPoint = "equihash_verify_144_5_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool equihash_verify_144_5(byte* header, int headerLength, byte* solution, int solutionLength, string personalization);

        [DllImport("libmultihash", EntryPoint = "equihash_verify_200_9_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool equihash_verify_200_9(byte* header, int headerLength, byte* solution, int solutionLength, string personalization);
    }
}