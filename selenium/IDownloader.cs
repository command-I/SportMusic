using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportMusic.selenium
{
    interface IDownloader
    {
        void DownloadBrowser(int index);

        void DownloadFromLink(string url, string path, string file);
    }
}
