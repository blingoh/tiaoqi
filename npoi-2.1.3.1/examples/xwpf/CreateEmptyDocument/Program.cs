﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.XWPF.UserModel;
using System.IO;

namespace CreateEmptyDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            XWPFDocument doc = new XWPFDocument();
            doc.CreateParagraph();
            using (FileStream sw = File.Create("blank.docx"))
            {
                doc.Write(sw);
            }
        }
    }
}
