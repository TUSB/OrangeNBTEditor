using OrangeNBT.NBT;
using System;

namespace OragngeNBTEditor.NBT
{
    internal class NBTAccesser
    {
        /// <summary>
        /// NBTタグから値を文字列で取得します
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static string GetValue(TagBase tag)
        {
            var value = "";
            switch(tag.TagType)
            {
                case TagType.Compound:
                    var compund = (TagCompound)tag;
                    value = compund.Count + " entries";
                    break;
                case TagType.List:
                    var list = (TagList)tag;
                    value = list.Count + " entries";
                    break;
                case TagType.Byte:
                    value = ((TagByte)tag).Value.ToString();
                    break;
                case TagType.ByteArray:
                    value = ((TagByteArray)tag).Value.Length + "bytes";
                    break;
                case TagType.Double:
                    value = ((TagDouble)tag).Value.ToString();
                    break;
                case TagType.Float:
                    value = ((TagFloat)tag).Value.ToString();
                    break;
                case TagType.Int:
                    value = ((TagInt)tag).Value.ToString();
                    break;
                case TagType.IntArray:
                    value = ((TagIntArray)tag).Value.Length + "integers";
                    break;
                case TagType.Long:
                    value = ((TagLong)tag).Value.ToString();
                    break;
                case TagType.LongArray:
                    value = ((TagLongArray)tag).Value.Length + "longs";
                    break;
                case TagType.Short:
                    value = ((TagShort)tag).Value.ToString();
                    break;
                case TagType.String:
                    value = ((TagString)tag).Value.ToString();
                    break;
                
            }

            return value;
        }

        /// <summary>
        /// NBTタグに値をセットします
        /// </summary>
        /// <param name="tag">NBT</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public static bool SetValue(TagBase tag, string value)
        {
            value = value.Replace(Environment.NewLine, "");
            bool success = false;
            try
            {
                switch (tag.TagType)
                {
                    case TagType.Byte:
                        ((TagByte)tag).Value = byte.Parse(value);
                        break;
                    case TagType.Double:
                        ((TagDouble)tag).Value = double.Parse(value);
                        break;
                    case TagType.Float:
                        ((TagFloat)tag).Value = float.Parse(value);
                        break;
                    case TagType.Int:
                        ((TagInt)tag).Value = int.Parse(value);
                        break;
                    case TagType.Long:
                        ((TagLong)tag).Value = long.Parse(value);
                        break;
                    case TagType.Short:
                        ((TagShort)tag).Value = short.Parse(value);
                        break;
                    case TagType.String:
                        ((TagString)tag).Value = value;
                        break;
                }
                success = true;
            }
            catch(Exception)
            {
                success = false;
            }
            

            return success;
        }
    }
}