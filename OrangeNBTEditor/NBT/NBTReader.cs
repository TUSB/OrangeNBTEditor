using OrangeNBT.NBT;
using System.Windows.Forms;

namespace SpringEditor.NBT
{
    class NBTReader
    {
        /// <summary>
        /// タグを再帰的に読み込んでTreeViewへ追加する
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static TreeNode AddTag(TagBase tag, TreeNode node)
        {
            var addnode = new TreeNode();
            string value = "";

            switch (tag.TagType)
            {
                case TagType.Compound:
                        var compund = (TagCompound)tag;
                        foreach (TagBase child in compund)
                        {
                            addnode = AddTag(child, addnode);

                        }
                    value = compund.Count.ToString() + " entries";
                    break;
                case TagType.List:
                        var list = (TagList)tag;
                        foreach (TagBase child in list)
                        {
                            addnode = AddTag(child, addnode);
                        }
                    value = list.Count.ToString() + " entries";
                    break;
                case TagType.Byte:
                    value = ((TagByte)tag).Value.ToString();
                    break;
                case TagType.ByteArray:
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
                    break;
                case TagType.Long:
                    value = ((TagLong)tag).Value.ToString();
                    break;
                case TagType.LongArray:
                    break;
                case TagType.Short:
                    value = ((TagShort)tag).Value.ToString();
                    break;
                case TagType.String:
                    value = ((TagString)tag).Value.ToString();
                    break;
            }

            if (!string.IsNullOrEmpty(tag.Name))
            {
                addnode.Text = tag.Name + ": " + value;
            }

            node.Nodes.Add(addnode);
            return node;
        }
    }
}
