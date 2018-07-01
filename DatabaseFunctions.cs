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
        public void TrackEdit(string command)
        {
            switch (command)
            {
                case "Добавить":
                    {

                        break;
                    }
                case "Редактировать": break;
                case "Удалить": break;
            }
        }

        /// <summary>
        /// Работа с таблицей User_Track (Треки пользователя, Мои композиции)
        /// Функции добавления, редактирования, удаления
        /// </summary>
        /// <param name="command"></param>
        public void User_Track_Edit(string command)
        {
            switch (command)
            {
                case "Добавить": break;
                case "Редактировать": break;
                case "Удалить": break;
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
