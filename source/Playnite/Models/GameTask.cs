﻿using LiteDB;
using Newtonsoft.Json;
using Playnite.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playnite.Models
{
    public enum GameTaskType : int
    {
        File = 0,
        URL = 1,
        Emulator = 2
    }

    public class GameTask : INotifyPropertyChanged
    {
        private GameTaskType type;
        public GameTaskType Type
        {
            get => type;
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        private bool isPrimary;
        public bool IsPrimary
        {
            get => isPrimary;
            set
            {
                isPrimary = value;
                OnPropertyChanged("IsPrimary");
            }
        }

        private string arguments;
        public string Arguments
        {
            get => arguments;
            set
            {
                arguments = value;
                OnPropertyChanged("Arguments");
            }
        }

        private string additionalArguments;
        public string AdditionalArguments
        {
            get => additionalArguments;
            set
            {
                additionalArguments = value;
                OnPropertyChanged("AdditionalArguments");
            }
        }

        private bool overrideDefaultArgs;
        public bool OverrideDefaultArgs
        {
            get => overrideDefaultArgs;
            set
            {
                overrideDefaultArgs = value;
                OnPropertyChanged("OverrideDefaultArgs");
            }
        }

        private string path;
        public string Path
        {
            get => path;
            set
            {
                path = value;
                OnPropertyChanged("Path");
            }
        }

        private string workingDir;
        public string WorkingDir
        {
            get => workingDir;
            set
            {
                workingDir = value;
                OnPropertyChanged("WorkingDir");
            }
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private bool isBuiltIn;
        public bool IsBuiltIn
        {
            get => isBuiltIn;
            set
            {
                isBuiltIn = value;
                OnPropertyChanged("IsBuiltIn");
            }
        }

        private ObjectId emulatorId;
        [JsonConverter(typeof(ObjectIdJsonConverter))]
        public ObjectId EmulatorId
        {
            get => emulatorId;
            set
            {
                emulatorId = value;
                OnPropertyChanged("EmulatorId");
            }
        }

        private ObjectId emulatorProfileId;
        [JsonConverter(typeof(ObjectIdJsonConverter))]
        public ObjectId EmulatorProfileId
        {
            get => emulatorProfileId;
            set
            {
                emulatorProfileId = value;
                OnPropertyChanged("EmulatorProfileId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
