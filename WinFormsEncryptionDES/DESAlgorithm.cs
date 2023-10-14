using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WinFormsEncryptionDES
{
    public class DESAlgorithm
    {
        private readonly byte[] _IP =
        {
            58 , 50 , 42 , 34 , 26 , 18 , 10 , 2 ,
            60 , 52 , 44 , 36 , 28 , 20 , 12 , 4 ,
            62 , 54 , 46 , 38 , 30 , 22 , 14 , 6 ,
            64 , 56 , 48 , 40 , 32 , 24 , 16 , 8 ,
            57 , 49 , 41 , 33 , 25 , 17 , 9  , 1 ,
            59 , 51 , 43 , 35 , 27 , 19 , 11 , 3 ,
            61 , 53 , 45 , 37 , 29 , 21 , 13 , 5 ,
            63 , 55 , 47 , 39 , 31 , 23 , 15 , 7
        };
        private readonly byte[] _IP1 =
        {
            40 , 8 , 48 , 16 , 56 , 24 , 64 , 32 ,
            39 , 7 , 47 , 15 , 55 , 23 , 63 , 31 ,
            38 , 6 , 46 , 14 , 54 , 22 , 62 , 30 ,
            37 , 5 , 45 , 13 , 53 , 21 , 61 , 29 ,
            36 , 4 , 44 , 12 , 52 , 20 , 60 , 28 ,
            35 , 3 , 43 , 11 , 51 , 19 , 59 , 27 ,
            34 , 2 , 42 , 10 , 50 , 18 , 58 , 26 ,
            33 , 1 , 41 , 9  , 49 , 17 , 57 , 25
        };
        private readonly byte[] _EBIT_SELECTION_TABLE =
        {
            32 , 1  , 2  , 3  , 4  , 5  ,
            4  , 5  , 6  , 7  , 8  , 9  ,
            8  , 9  , 10 , 11 , 12 , 13 ,
            12 , 13 , 14 , 15 , 16 , 17 ,
            16 , 17 , 18 , 19 , 20 , 21 ,
            20 , 21 , 22 , 23 , 24 , 25 ,
            24 , 25 , 26 , 27 , 28 , 29 ,
            28 , 29 , 30 , 31 , 32 , 1
        };
        private readonly byte[] _P =
        {
            16 , 7  , 20 , 21 ,
            29 , 12 , 28 , 17 ,
            1  , 15 , 23 , 26 ,
            5  , 18 , 31 , 10 ,
            2  , 8  , 24 , 14 ,
            32 , 27 , 3  , 9  ,
            19 , 13 , 30 , 6  ,
            22 , 11 , 4  , 25
        };
        private readonly byte[] _PC1 =
        {
            57 , 49 , 41 , 33 , 25 , 17 , 9  ,
            1  , 58 , 50 , 42 , 34 , 26 , 18 ,
            10 , 2  , 59 , 51 , 43 , 35 , 27 ,
            19 , 11 , 3  , 60 , 52 , 44 , 36 ,
            63 , 55 , 47 , 39 , 31 , 23 , 15 ,
            7  , 62 , 54 , 46 , 38 , 30 , 22 ,
            14 , 6  , 61 , 53 , 45 , 37 , 29 ,
            21 , 13 , 5  , 28 , 20 , 12 , 4
        };
        private readonly byte[] _PC2 =
        {
            14 , 17 , 11 , 24 , 1  , 5  ,
            3  , 28 , 15 , 6  , 21 , 10 ,
            23 , 19 , 12 , 4  , 26 , 8  ,
            16 , 7  , 27 , 20 , 13 , 2  ,
            41 , 52 , 31 , 37 , 47 , 55 ,
            30 , 40 , 51 , 45 , 33 , 48 ,
            44 , 49 , 39 , 56 , 34 , 53 ,
            46 , 42 , 50 , 36 , 29 , 32
        };
        private readonly byte[] _TABLE_SHIFT_BIT =
        {
            1 , 1 , 2 , 2 , 2 , 2 , 2 , 2 , 1 , 2 , 2 , 2 , 2 , 2 , 2 , 1
        };
        private readonly byte[] _S1 =
        {
            14 , 4  , 13 , 1 , 2  , 15 , 11 , 8  , 3  , 10 , 6  , 12 , 5  , 9  , 0 , 7  ,
            0  , 15 , 7  , 4 , 14 , 2  , 13 , 1  , 10 , 6  , 12 , 11 , 9  , 5  , 3 , 8  ,
            4  , 1  , 14 , 8 , 13 , 6  , 2  , 11 , 15 , 12 , 9  , 7  , 3  , 10 , 5 , 0  ,
            15 , 12 , 8  , 2 , 4  , 9  , 1  , 7  , 5  , 11 , 3  , 14 , 10 , 0  , 6 , 13
        };
        private readonly byte[] _S2 =
        {
            15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10,
            3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5,
            0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15,
            13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9
        };
        private readonly byte[] _S3 =
        {
            10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8,
            13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1,
            13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7,
            1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12
        };
        private readonly byte[] _S4 =
        {
            7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15,
            13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9,
            10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4,
            3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14
        };
        private readonly byte[] _S5 =
        {
            2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9,
            14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6,
            4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14,
            11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3
        };
        private readonly byte[] _S6 =
        {
            12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11,
            10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8,
            9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6,
            4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13
        };
        private readonly byte[] _S7 =
        {
            4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1,
            13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6,
            1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2,
            6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12
        };
        private readonly byte[] _S8 =
        {
            13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7,
            1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2,
            7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8,
            2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11
        };
        private ulong _key;
        private uint _c0;
        private uint _d0;
        private ulong[] _blocks;
        private bool _isDataHex = true;
        public string[] HistoryKey = new string[16];
        public List<string> HistoryLeft = new List<string>();
        public List<string> HistoryRight = new List<string>();
        public bool IsDataHex
        {
            set => _isDataHex = value;

            get => _isDataHex;
        }
        public virtual ulong Key
        {
            set
            {
                _key = value;
                InitalKey();
            }
            get => _key;
        }
        private string _data;
        public string Data
        {
            set
            {
                _data = value;
                _blocks = SplitData(_data);
            }
            get => _data;
        }
        public ulong[] Blocks { get => _blocks; }
        public DESAlgorithm()
            : this(null, 0)
        {}
        public DESAlgorithm(string data,ulong key, bool isDataHex = true)
           => Inital(data, key,isDataHex);
        protected virtual void Inital(string data,ulong key, bool isDataHex)
        {
            Data = data;
            Key = key;
            _isDataHex = isDataHex;
        }
        protected virtual void InitalKey()
        {
            uint[] uints = SplitInt64ToDouble28Bit(PermutationPC1(_key));
            _c0 = uints[0];
            _d0 = uints[1];
        }
        public uint[] SplitInt64ToDouble32Bit(ulong value)
        {
            uint right = (uint)(value & 0xffffffff);
            value >>= 32;
            uint left = (uint)(value & 0xffffffff);
            return new uint[] { left,right };
        }
        public uint[] SplitInt64ToDouble28Bit(ulong value)
        {
            uint right = (uint)(value & 0xfffffff);
            value >>= 28;
            uint left = (uint)(value & 0xfffffff);
            return new uint[] { left, right };
        }
        public void FormatTo28Bit(ref uint value)
            => value &= 0xfffffff;
        public byte GetBitIndex64(ulong value, int number)
            => (value >> (number - 1) & (Int64)1) == (Int64)1 ? (byte)1 : (byte)0;
        public byte GetBitIndex32(uint value, int number)
            => (value >> (number - 1) & 1) == 1 ? (byte)1 : (byte)0;
        public byte GetBitIndexByte(byte value, int number)
            => (value >> (number - 1) & 1) == 1 ? (byte)1 : (byte)0;
        public void LeftShift(ref uint value)
        {
            byte bitLeading = GetBitIndex32(value,28);
            value <<= 1;
            value |= bitLeading;
        }
        public void LeftShiftBits(ref uint value,byte numberCalls)
        {
            for (byte b = 0; b < numberCalls; b++)
                LeftShift(ref value);
        }
        public ulong Merge64Bit(uint left,uint right,byte leftShift)
        {
            ulong left64 = left;
            ulong right64 = right;
            left64 <<= leftShift;
            return left64 | right64;
        }
        protected ulong PermutationPC1(ulong value)
        {
            ulong result = 0;
            byte temp;
            byte length = (byte)PermutionTables.PC1;
            for (byte b = 0; b < length; b++)
            {
                temp = GetBitIndex64(value, 65 - _PC1[b]);
                result |= temp;
                result <<= 1;
            }
            return result >> 1;
        }
        protected ulong PermutationPC2(ulong value)
        {
            ulong result = 0;
            byte temp;
            byte length = (byte)PermutionTables.PC2;
            for (byte b = 0; b < length; b++)
            {
                temp = GetBitIndex64(value, 57 - _PC2[b]);
                result |= temp;
                result <<= 1;
            }
            return result >> 1;
        }
        // GENERATE NEW KEY
        private ulong GenerateKey(ref uint left, ref uint right,int number)
        {
            LeftShiftBits(ref left, _TABLE_SHIFT_BIT[number - 1]);
            LeftShiftBits(ref right, _TABLE_SHIFT_BIT[number - 1]);
            FormatTo28Bit(ref left);
            FormatTo28Bit(ref right);
            return PermutationPC2(Merge64Bit(left, right,28));
        }
        protected ulong PermutionE(uint value)
        {
            ulong result = 0;
            byte temp;
            byte length = (byte)PermutionTables.E;
            for (byte b = 0; b < length; b++)
            {
                temp = GetBitIndex64(value, 33 - _EBIT_SELECTION_TABLE[b]);
                result |= temp;
                result <<= 1;
            }
            return result >> 1;
        }
        private byte GetValueIndexOfBox(byte value,BoxS boxName)
        {
            byte index = 0;
            byte temp;
            byte[] nums = { 6, 1, 5, 4, 3, 2 };
            for (byte b = 0; b < 6; b++)
            {
                temp = GetBitIndexByte(value, nums[b]);
                index |= temp;
                index <<= 1;
            }
            index >>= 1;
            switch (boxName)
            {
                case BoxS.S1:
                    temp = _S1[index];
                    break;
                case BoxS.S2:
                    temp = _S2[index];
                    break;
                case BoxS.S3:
                    temp = _S3[index];
                    break;
                case BoxS.S4:
                    temp = _S4[index];
                    break;
                case BoxS.S5:
                    temp = _S5[index];
                    break;
                case BoxS.S6:
                    temp = _S6[index];
                    break;
                case BoxS.S7:
                    temp = _S7[index];
                    break;
                case BoxS.S8:
                    temp = _S8[index];
                    break;
                default:
                    temp = 0;
                    break;
            }
            return temp;
        }
        private uint GatherToInt32(byte[] bytes)
        {
            uint result = 0;
            for (byte b = 0; b < 7; b++)
            {
                result |= bytes[b];
                result <<= 4;
            }
            return result | bytes[7];
        }
        protected uint PermutionP(uint value)
        {
            uint result = 0;
            byte temp;
            byte length = (byte)PermutionTables.P;
            for (byte b = 0; b < length - 1; b++)
            {
                temp = GetBitIndex32(value, 33 - _P[b]);
                result |= temp;
                result <<= 1;
            }
            return result | GetBitIndex32(value, 33 - _P[length-1]);
        }
        private uint Feistel(uint right, ulong key)
        {
            ulong E = PermutionE(right);
            ulong E_XOR_KEY = E ^ key;

            byte[] bytes = new byte[8];
            BoxS[] boxs = { BoxS.S1, BoxS.S2, BoxS.S3, BoxS.S4, BoxS.S5, BoxS.S6, BoxS.S7, BoxS.S8 };
            byte temp;
            for (byte b = 0; b < 8; b++)
            {
                temp = (byte)(E_XOR_KEY & 0x3f);
                bytes[7-b] = GetValueIndexOfBox(temp, boxs[7-b]);
                E_XOR_KEY >>= 6;
            }
            uint value = GatherToInt32(bytes);
            return PermutionP(value);
        }
        protected ulong PermutionIP(ulong block)
        {
            ulong result = 0;
            byte temp;
            byte length = (byte)PermutionTables.IP;
            for (byte b = 0; b < length - 1; b++)
            {
                temp = GetBitIndex64(block, 65 - _IP[b]);
                result |= temp;
                result <<= 1;
            }
            return result | GetBitIndex64(block, 65 - _IP[length - 1]);
        }
        protected ulong PermutionInverseIP(ulong data)
        {
            ulong result = 0;
            byte temp;
            byte length = (byte)PermutionTables.IP1;
            for (byte b = 0; b < length-1; b++)
            {
                temp = GetBitIndex64(data, 65 - _IP1[b]);
                result |= temp;
                result <<= 1;
            }
            return result | GetBitIndex64(data, 65 - _IP1[length - 1]);
        }
        protected virtual string BuildEnCode(ulong block)
        {
            return BuildEnCode(block,_c0,_d0);
        }
        protected virtual string BuildEnCode(ulong block,uint __c0,uint __d0)
        {
            uint[] uints = SplitInt64ToDouble32Bit(PermutionIP(block));
            uint l0 = uints[0];
            uint r0 = uints[1];
            uint c0 = __c0;
            uint d0 = __d0;
            ulong newKey;
            uint temp;
            for (int i = 1; i <= 16; i++)
            {
                newKey = GenerateKey(ref c0,ref d0,i);
                temp = r0;
                r0 = l0 ^ Feistel(r0, newKey);
                l0 = temp;
                SaveHistory(i - 1, newKey, l0, r0);
            }
            ulong a = Merge64Bit(r0, l0, 32);
            return PermutionInverseIP(a).ToString("x").PadLeft(16, '0').ToUpper();
        }
        public virtual string EnCode()
        {
            int size = _blocks.Length;
            string res = (size == 0? null: "");
            for(int i = 0; i < size; i++)
                res += BuildEnCode(_blocks[i]);
            return res;
        }
        protected virtual string BuildDeCode(ulong block,uint __c0,uint __d0)
        {
            uint[] uints = SplitInt64ToDouble32Bit(PermutionIP(block));
            uint l0 = uints[0];
            uint r0 = uints[1];
            uint c0 = __c0;
            uint d0 = __d0;
            ulong[] keys = new ulong[16];
            ulong key;
            uint temp;
            for (int i = 1; i <= 16; i++)
            {
                keys[i-1] = GenerateKey(ref c0, ref d0, i);
            }
            for (int i = 0; i < 16; i++)
            {
                key = keys[15 - i];
                temp = r0;
                r0 = l0 ^ Feistel(r0, key);
                l0 = temp;
                SaveHistory(i, key, l0, r0);
            }
            ulong a = Merge64Bit(r0, l0, 32);
            return PermutionInverseIP(a).ToString("x").PadLeft(16,'0').ToUpper();
        }
        public virtual string DeCode(bool returnTypeText = false)
        {
            int size = _blocks.Length;
            string res = (size == 0 ? null : "");
            for (int i = 0; i < size; i++)
                res += BuildDeCode(_blocks[i], _c0, _d0);
            if (returnTypeText)
                return HexToPlainText(res);
            return res;
        }
        private ulong[] SplitData(string data)
        {
            if (string.IsNullOrEmpty(data))
                return new ulong[0];
            if (_isDataHex)
            {
                return SplitDataHex(data);
            }
            return SplitDataText(data);
        }
        private ulong[] SplitDataHex(string data)
        {
            int length = data.Length;
            int r = length % 16;
            int lengthBlocks = (r == 0 ? length/16 : (length/16)+1);
            ulong[] blocks = new ulong[lengthBlocks];
            int temp = 0;
            try
            {
                if (r != 0)
                    data = data.PadRight(lengthBlocks * 16,'0');
                for (int i = 0; i < lengthBlocks; i++, temp += 16)
                    blocks[i] = ulong.Parse(data.Substring(temp, 16), NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                throw;
            }
            return blocks;
        }
        private ulong[] SplitDataText(string data)
        {
            string dataHex = PlainTextToHex(data);
            return SplitDataHex(dataHex);
        }
        private void SaveHistory(int index,ulong hKey,uint hLeft,uint hRight)
        {
            HistoryKey[index] = hKey.ToString("x");
            HistoryLeft.Add(hLeft.ToString("x"));
            HistoryRight.Add(hRight.ToString("x"));
        }
        private string HexToPlainText(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return Encoding.UTF8.GetString(bytes);
        }
        private string PlainTextToHex(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }

    public enum PermutionTables
    {
        IP = 64,
        IP1 = 64,
        E = 48,
        P = 32,
        PC1 = 56,
        PC2 = 48
    }
    public enum BoxS
    {
        S1,S2,S3,S4,S5,S6,S7,S8
    }
}
