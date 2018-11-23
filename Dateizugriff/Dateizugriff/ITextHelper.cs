using System;
using System.Collections.Generic;
using System.Text;

namespace Dateizugriff
{
    public interface ITextHelper
    {
        void SaveText(string content, string path);
        string LoadText(string path);
    }
}
