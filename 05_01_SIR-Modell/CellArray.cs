using System.Text;

namespace SIR_Modell
{
    public class CellArray : List<List<object>>
    {
        public CellArray()
            : base()
        {
        }

        int maxCol;

        public object this[int row, int col]
        {
            get
            {
                if (row >= this.Count)
                    throw new Exception("CellArray: Row mit Index " + row + " nicht vorhanden.");
                List<object> rowList = this[row];
                if (col >= rowList.Count)
                    return "";
                object o = rowList[col];
                if (o == null)
                    return "";
                var s = o as string;
                if (o is DateTime)
                    return ((DateTime)o).ToString("yyyy-MM-dd hh:mm:ss");
                return o?.ToString() ?? "";
            }
            set
            {
                var valstr = value as string;
                if (valstr != null)
                {
                    if (valstr.IndexOf(';') > -1 && valstr[0] != '"')
                    {
                        valstr = "\"" + valstr + "\"";
                    }
                    valstr = valstr.Replace('\n', ' ').Replace('\r', ' ');
                    value = valstr;
                }
                while (Count <= row)
                    this.Add(new List<object>());

                List<object> rowList = this[row];
                while (rowList.Count <= col)
                    rowList.Add(string.Empty);

                rowList[col] = value;
                this.maxCol = Math.Max(col + 1, maxCol);
            }
        }

        public MemoryStream ToStream()
        {
            MemoryStream ms = new MemoryStream();
            ToStream(ms);
            ms.Seek(0L, SeekOrigin.Begin);
            return ms;
        }

        public void ToStream(Stream stream)
        {
            StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);
            ToStreamWriter(sw);
            sw.Flush();
        }

        public void ToStreamWriter(StreamWriter sw)
        {
            for (int r = 0; r < this.RowCount; r++)
            {
                int end = ColCount - 1;
                for (int c = 0; c < ColCount; c++)
                {
                    sw.Write(this[r, c].ToString() + (c < end ? ";" : string.Empty));
                }
                sw.WriteLine();
            }
        }

        public int RowCount
        {
            get
            {
                return this.Count;
            }
        }

        public int ColCount
        {
            get
            {
                return this.maxCol;
            }
        }
    }
}
