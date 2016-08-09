using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Lunchbox
{
    public class Lunch
    {
        public enum DirOrFile
        {
            Folder,
            File,
        };

        public enum Pos
        {
            Default,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight,
        };

        public int id { get; set; }
        public DirOrFile dirOrFile { get; set; }
        public string path { get; set; }
        public Pos pos { get; set; }

        public Lunch()
        {
            id = 0;
            dirOrFile = DirOrFile.Folder;
            path = "";
            pos = Pos.Default;
        }

        public Lunch(int tempId, DirOrFile tempDirOrFile, string tempPath, Pos tempPos)
        {
            id = tempId;
            dirOrFile = tempDirOrFile;
            path = tempPath;
            pos = tempPos;
        }
    }
}
