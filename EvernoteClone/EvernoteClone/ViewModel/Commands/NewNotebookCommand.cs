﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EvernoteClone.ViewModel.Commands
{
    public class NewNotebookCommand : ICommand
    {

        public NotesVM VM { get; set; }

        public NewNotebookCommand(NotesVM vm ) { 
            VM = vm;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //TO DO: 
            VM.CreateNotebook();
        }
    }
}
