using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportMusic.selenium
{
    interface ITrackFinder
    {
        /// <summary>
        /// Отправляет строку для поиска в поле поиска на сайте.
        /// Переходит на страницу результатов поиска.
        /// </summary>
        /// <param name="search"></param>
        void GoArtistTrackSearch(string search);

        void GoToSelectGenre();

        void GoToSelectMood();

        List<TrackOptions> Result();

    }


}
