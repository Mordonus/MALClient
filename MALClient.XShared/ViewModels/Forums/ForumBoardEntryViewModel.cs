﻿using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MALClient.Models.Models.Forums;
using MALClient.XShared.Utils.Enums;

namespace MALClient.XShared.ViewModels.Forums
{
    public class ForumBoardEntryViewModel : ViewModelBase
    {
        public ForumBoardEntryViewModel(string name, string description, FontAwesomeIcon icon,ForumBoards board)
        {
            Entry = new ForumBoardEntry {Name = name, Description = description};
            Icon = icon;
            Board = board;
        }

        public ForumBoardEntry Entry { get; }   

        public FontAwesomeIcon Icon { get; }

        public ForumBoards Board { get; }

        public void SetPeekPosts(IEnumerable<ForumBoardEntryPeekPost> posts)
        {
            Entry.PeekPosts = posts;
            RaisePropertyChanged(() => Entry);
        }

        public ICommand AddToFavouritesCommand
            => new RelayCommand<ForumBoards>(board => ViewModelLocator.ForumsMain.AddFavouriteBoard(board));


    }
}
