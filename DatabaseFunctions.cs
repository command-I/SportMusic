using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace SportMusic
{
    class DatabaseFunctions
    {
        public Intensiv2018Entities context = new Intensiv2018Entities();

        public DatabaseFunctions()
        {

        }


        /// <summary>
        /// Работа с таблицей User (Пользователи)
        /// Функции добавления, редактирования, удаления
        /// </summary>
        /// <param name="command"></param>
        public void UserEdit(string command, int id, string role, string login, string pass, string name, string surname, string email, int phone, string path)
        {
            switch (command)
            {
                case "Добавить":
                    {
                        SysUser user = new SysUser();
                        user.id = -1;
                        user.role = role;
                        user.login = login;
                        user.pass = pass;
                        user.name = name;
                        user.surname = surname;
                        user.email = email;
                        user.phone = phone;
                        user.path_to_files = path;
                        context.Entry(user).State = EntityState.Added;
                        context.SaveChanges();
                        break;
                    }
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
        /// <param name="id"></param>
        /// <param name="author"></param>
        /// <param name="artist"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="mood"></param>
        /// <param name="bitrate"></param>
        /// <param name="sourse"></param>
        /// <param name="path"></param>
        /// <param name="duration"></param>
        public void User_Track_Edit(string command, int id, int? author=0, string artist="", string title="", string genre="", string mood="", int? bitrate=0,
            string sourse="", string path="", TimeSpan duration=new TimeSpan())
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

        public List<User_Track> Get_User_Track(int id)
        {
            return context.User_Track.OrderBy(a => a.id).Where(a=>a.author == id).ToList();
        }

        public List<User_Track> Search_User_Track(int id, string artist="", string title="", string genre="", string mood="")
        {
            List<User_Track> list = context.User_Track.OrderBy(a => a.id).Where(a => a.author == id).ToList();
            if (artist != "")
                list = list.Where(a => a.artist == artist).ToList();
            if (title != "")
                list = list.Where(a => a.title == title).ToList();
            if (genre != "")
                list = list.Where(a => a.genre == genre).ToList();
            if (mood != "")
                list = list.Where(a => a.mood == mood).ToList();
            return list;
        }

        /// <summary>
        /// Работа с таблицей Playlist (Плейлисты)
        /// Функции добавления, редактирования, удаления 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <param name="author"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="duration"></param>
        public void PlaylistEdit(string command,int id,  List<User_Track> tracks, int author= 0, string surname="", string name="", string title="", TimeSpan duration = new TimeSpan())
        {
            switch (command)
            {
                case "Добавить":
                    {
                        Playlist playlist = new Playlist();
                        string full_title= title ;
                        
                        playlist.id = id;
                        playlist.author = author;
                        playlist.title = full_title;
                        playlist.date_create = DateTime.Now;
                        playlist.date_edit = DateTime.Now;
                        playlist.duration = duration;
                        playlist.surname = surname;
                        playlist.name = name;

                        context.Entry(playlist).State = EntityState.Added;
                        context.SaveChanges();

                        int? position = context.User_Track_Playlist.Where(a=>a.playlist_id == id).Max(a => a.position);
                        if (position == null)
                            position = 0;
                        foreach (User_Track track in tracks)
                        {
                            position++;
                            User_Track_Playlist_Edit("Добавить", playlist.id, track.track_id, position, -1);
                        }

                        break;
                    }
                case "Редактировать":
                    {
                        try
                        {
                            //Добавление в треки пользователя
                            Playlist playlist = context.Playlist.Find(id);

                            string full_title = title;

                            playlist.id = id;
                            playlist.author = author;
                            playlist.title = full_title;
                            playlist.date_create = DateTime.Now;
                            playlist.date_edit = DateTime.Now;
                            playlist.duration = duration;
                            playlist.surname = surname;
                            playlist.name = name;

                            context.Entry(playlist).State = EntityState.Modified;
                            context.SaveChanges();

                            //Удалили все связанные данные из таблицы User_Track_Playlist
                            context.User_Track_Playlist.RemoveRange(context.User_Track_Playlist.Where(a => a.playlist_id == id));
                            context.SaveChanges();

                            int? position = context.User_Track_Playlist.Where(a => a.playlist_id == id).Max(a => a.position);
                            if (position == null)
                                position = 0;
                            foreach (User_Track track in tracks)
                            {
                                position++;
                                User_Track_Playlist_Edit("Добавить", playlist.id, track.track_id, position, -1);
                            }
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
                case "Удалить":
                    {
                        try
                        {

                            foreach (User_Track track in tracks)
                            {
                                context.User_Track_Playlist.RemoveRange(context.User_Track_Playlist.Where(a => a.track_id == track.track_id));
                            }
                            
                            Playlist playlist = context.Playlist.Find(id);
                            context.Entry(playlist).State = EntityState.Deleted;
                            context.SaveChanges();
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
            }
        }


        public List<Playlist> Get_Playlist(int id)
        {
            return context.Playlist.OrderBy(a => a.id).Where(a=>a.author==id).ToList();
        }

        /// <summary>
        /// Работа с таблицей User_Track_Playlist (Таблица, соединяющая треки и плейлисты)
        /// Функции добавления, удаления, редактирования
        /// </summary>
        /// <param name="command"></param>
        /// <param name="id"></param>
        /// <param name="playlist_id"></param>
        /// <param name="track_id"></param>
        public void User_Track_Playlist_Edit(string command, int playlist_id, int track_id, int? position=0, int id=0)
        {
            switch (command)
            {
                case "Добавить":
                    {
                        User_Track_Playlist user_Track_Playlist = new User_Track_Playlist();

                        user_Track_Playlist.id = id;
                        user_Track_Playlist.playlist_id = playlist_id;
                        user_Track_Playlist.track_id = track_id;
                        user_Track_Playlist.position = position;

                        context.Entry(user_Track_Playlist).State = EntityState.Added;
                        context.SaveChanges();



                        break;
                    }
                //case "Редактировать":
                //    {
                //        try
                //        {
                //            List<User_Track_Playlist> list = context.User_Track_Playlist.Where(a => a.playlist_id == playlist_id).ToList();

                //            foreach (User_Track_Playlist temp in list)
                //            {
                //                User_Track_Playlist_Edit("Удалить", temp.playlist_id, temp.track_id,0,temp.id);
                //            }
                            

                //            User_Track_Playlist_Edit("Добавить", playlist_id, track_id);
                            

                //        }
                //        catch (Exception ex) { Console.WriteLine(ex.Message); }
                //        break;
                //    }
                case "Удалить":
                    {
                        try
                        {
                            User_Track_Playlist user_Track_Playlist = context.User_Track_Playlist.Find(id);
                            context.Entry(user_Track_Playlist).State = EntityState.Deleted;
                            context.SaveChanges();
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        break;
                    }
            }
        }

        public List<User_Track_Playlist> GetUser_Track_Playlist(int id)
        {
            return context.User_Track_Playlist.OrderBy(a => a.id).Where(a => a.playlist_id == id).ToList();
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
