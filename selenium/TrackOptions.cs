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
        public TrackOptions(int num, string artist, string track, string duration, string url, string name)
        {
            Num = num;
            Artist = artist;
            Track = track;
            Duration = duration;
            DownloadUrl = url;
            FileName = name;
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
        private int TimeStringToInt(string time)
        {
            int minDec = Int32.Parse(time[0].ToString()) * 600;
            int minEd = Int32.Parse(time[1].ToString()) * 60;
            int secDec = Int32.Parse(time[3].ToString()) * 10;
            int secEd = Int32.Parse(time[4].ToString());

            return minDec + minEd + secDec + secEd;
        }
    }
}
