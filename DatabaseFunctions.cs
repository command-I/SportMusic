using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SportMusic
{
    class DatabaseFunctions
    {
        public static Intensiv2018Entities context = new Intensiv2018Entities();

        public DatabaseFunctions()
        {

        }


        /// <summary>
        /// Работа с таблицей User (Пользователи)
        /// Функции добавления, редактирования, удаления
        /// </summary>
        /// <param name="command"></param>
        public void UserEdit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
                case "Редактировать": break;
                case "Удалить": break;
            }
        }

        /// <summary>
        /// Работа с таблицей Track (Треки)
        /// Функции добавления, редактирования, удаления
        /// </summary>
        /// <param name="command"></param>

        public void TrackEdit(string command, int id, int downloader, string artist, string title, string genre, string mood, int bitrate, 
            string sourse, string path, TimeSpan duration)
        {
            switch (command)
            {
                case "Добавить":
                    {
                        //try
                        // {
                        //Добавление в общие треки
                        Track track = new Track();

                        track.id = -1;
                        track.downloader = downloader;
                        track.artist = artist;
                        track.title = title;
                        track.genre = genre;
                        track.mood = mood;
                        track.bitrate = bitrate;
                        track.source = sourse;
                        track.path = path;
                        track.duration = duration;
                        track.date_add = DateTime.Now.Date;
                        context.Entry(track).State = EntityState.Added;

                        context.SaveChanges();

                        //Добавление в треки пользователя
                        User_Track_Edit("Добавить", 0, downloader, artist, title, genre, mood, bitrate, sourse, path, duration);
                        // }
                        //catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
                case "Редактировать":
                    {
                        try
                        {
                            Track track = context.Tracks1.Find(id);

                            track.downloader = downloader;
                            track.artist = artist;
                            track.title = title;
                            track.genre = genre;
                            track.mood = mood;
                            track.bitrate = bitrate;
                            track.source = sourse;
                            track.path = path;
                            track.duration = duration;
                            track.date_add = DateTime.Now;

                            context.Entry(track).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
                case "Удалить":
                    {
                        try
                        {
                            Track track = context.Tracks1.Find(id);
                            context.Entry(track).State = EntityState.Deleted;
                            context.SaveChanges();
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
            }
        }

        /// <summary>
        /// Работа с таблицей User_Track (Треки пользователя, Мои композиции)
        /// Функции добавления, редактирования, удаления
        /// </summary>
        /// <param name="command"></param>
        public void User_Track_Edit(string command, int id, int author, string artist, string title, string genre, string mood, int bitrate,
            string sourse, string path, TimeSpan duration)
        {
            switch (command)
            {
                case "Добавить":
                    {
                        //try
                        //{
                            int track_id = context.Tracks1.Where(a => a.source == sourse).Select(a => a.id).FirstOrDefault();

                            //Добавление в треки пользователя
                            User_Track user_track = new User_Track();

                            user_track.id = id;
                            user_track.track_id = track_id;
                            user_track.author = author;
                            user_track.artist = artist;
                            user_track.title = title;
                            user_track.genre = genre;
                            user_track.mood = mood;
                            user_track.bitrate = bitrate;
                            user_track.source = sourse;
                            user_track.path = path;
                            user_track.duration = duration;
                            user_track.date_add = DateTime.Now;

                            context.Entry(user_track).State = EntityState.Added;
                            context.SaveChanges();

                       // }
                        //catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
                case "Редактировать":
                    {
                        try
                        {
                            int track_id = context.Tracks1.Where(a => a.source == sourse).Select(a => a.id).FirstOrDefault();

                            //Добавление в треки пользователя
                            User_Track user_track = context.User_Track.Find(id);

                            user_track.track_id = track_id;
                            user_track.author = author;
                            user_track.artist = artist;
                            user_track.title = title;
                            user_track.genre = genre;
                            user_track.mood = mood;
                            user_track.bitrate = bitrate;
                            user_track.source = sourse;
                            user_track.path = path;
                            user_track.duration = duration;
                            user_track.date_add = DateTime.Now;

                            context.Entry(user_track).State = EntityState.Modified;
                            context.SaveChanges();

                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
                case "Удалить":
                    {
                        try
                        {
                            User_Track user_track = context.User_Track.Find(id);
                            context.Entry(user_track).State = EntityState.Deleted;
                            context.SaveChanges();
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
            }
        }


        /// <summary>
        /// Работа с таблицей Playlist (Плейлисты)
        /// Функции добавления, редактирования, удаления 
        /// </summary>
        /// <param name="command"></param>
        public void PlaylistEdit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
                case "Редактировать": break;
                case "Удалить": break;
            }
        }

        /// <summary>
        /// Работа с таблицей User_Playlist (Пользователи-Плейлисты). Предназначена для установки видимости плейлистов другим пользователям
        /// Функции добавления, редактирования, удаления
        /// </summary>
        /// <param name="command"></param>
        public void User_Playlist_Edit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
                case "Редактировать": break;
                case "Удалить": break;
            }
        }

        /// <summary>
        /// Работа с таблицей Edit_User (Изменения пользователей). Предназначена для хранения истории изменений данных аккаунтов
        /// Функции добавления
        /// </summary>
        /// <param name="command"></param>
        public void Edit_User_Edit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
            }
        }

        /// <summary>
        /// Работа с таблицей Edit_Track (Изменения треков). Предназначена для хранения истории изменений данных треков пользователей
        /// Функции добавления
        /// </summary>
        /// <param name="command"></param>
        public void Edit_Track_Edit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
            }
        }

        /// <summary>
        /// Работа с таблицей Edit_Playlist (Изменения плейлистов). Предназначена для хранения истории изменений данных плейлистов пользователей
        /// Функции добавления
        /// </summary>
        /// <param name="command"></param>
        public void Edit_Playlist_Edit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
            }
        }
    }

}
