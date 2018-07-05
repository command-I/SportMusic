using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportMusic.selenium
{
    public class TrackOptions : ICloneable
    {
        public int Num { get; set; }
        public string Artist { get; set; }
        public string Track { get; set; }
        public string Duration { get; set; }
        public string DownloadUrl { get; set; }
        public string FileName { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="num">Принимает порядковый номер.</param>
        /// <param name="artist">Принимает имя артиста.</param>
        /// <param name="track">Принимает название трека.</param>
        /// <param name="duration">Принимает строку со значением времени.</param>
        /// <param name="url">Принимает url.</param>
        /// <param name="name">Иринимает имя файла</param>
        public TrackOptions(int num, string artist, string track, string duration, string url, string file)
        {
            Num = num;
            Artist = artist;
            Track = track;
            Duration = duration;
            DownloadUrl = url;
            FileName = file;
        }

        /// <summary>
        /// Клонирование объектов класса.
        /// </summary>
        /// <returns>Возвращает клон объекта.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Преобразование строки со значением длительности в числовое значение. 
        /// </summary>
        /// <param name="time">Принимает строку со значением времени.</param>
        /// <returns>Возврашает количество секунд.</returns>
        public int TimeStringToInt(string time)
        {
            int minDec;
            int minEd;
            int secDec;
            int secEd;

            try
            {
                minDec = Int32.Parse(time[0].ToString()) * 600;
                minEd = Int32.Parse(time[1].ToString()) * 60;
                secDec = Int32.Parse(time[3].ToString()) * 10;
                secEd = Int32.Parse(time[4].ToString());
            }
            catch (Exception)
            {
                return -1;
            }

            return minDec + minEd + secDec + secEd;
        }
    }
}
