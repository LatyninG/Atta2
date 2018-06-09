using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class TF
    {
        public string Path { get; private set; }
        public TF(string path)
        {
            this.Path = path;
        } 

        public MyQueue Read()
        {
            FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            MyQueue mq = new MyQueue();
            while (!sr.EndOfStream)
            {
                string p = sr.ReadLine();
                mq.InQueue(Convert.ToInt32(p));
            }
            sr.Close();
            fs.Close();
            return mq;
        }
    }
}
