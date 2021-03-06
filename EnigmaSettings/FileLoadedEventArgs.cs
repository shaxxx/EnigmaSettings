// Copyright (c) 2013 Krkadoni.com - Released under The MIT License.
// Full license text can be found at http://opensource.org/licenses/MIT
     
using System;
using System.IO;

namespace Krkadoni.EnigmaSettings
{
    public sealed class FileLoadedEventArgs : EventArgs
    {

        private readonly string _file;
        private readonly bool _success;

        public FileLoadedEventArgs(string file, bool success)
        {
            _file = file;
            _success = success;
        }

        /// <summary>
        ///     File we tried to load
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string File
        {
            get { return _file; }
        }

        /// <summary>
        ///     Success of the load operation
        /// </summary>
        /// <value></value>
        /// <returns>True if load suceeded, false if it fails</returns>
        /// <remarks></remarks>
        public bool Success
        {
            get { return _success; }
        }
    }
}