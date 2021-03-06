// Copyright (c) 2013 Krkadoni.com - Released under The MIT License.
// Full license text can be found at http://opensource.org/licenses/MIT

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Krkadoni.EnigmaSettings.Interfaces
{
    public interface IBouquet : INotifyPropertyChanged, IEditableObject, ICloneable
    {
        /// <summary>
        ///     Type of settings file
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        Enums.BouquetType BouquetType { get; }

        /// <summary>
        ///     Bouquet items
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        IList<IBouquetItem> BouquetItems { get; set; }

        /// <summary>
        ///     Bouquet name
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        string Name { get; set; }

        /// <summary>
        /// Performs MemberwiseClone on current object
        /// </summary>
        /// <returns></returns>
        object ShallowCopy();

    }
}