// Accord Statistics Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Statistics.Models.Markov
{
    using System;
    using System.IO;

    /// <summary>
    ///   Common interface for sequence classifiers using <see cref="IHiddenMarkovModel">
    ///   hidden Markov models that guarantees the ability to save</see>.
    /// </summary>

    public interface ISaveableHiddenMarkovClassifier : IHiddenMarkovClassifier
    {

        /// <summary>
        ///   Saves the Hidden Markov Classifier to the specified Output Stream
        /// </summary>
        /// 
        /// <param name="path">The stream to which the classifier is to be serialized.</param>
        /// 
        void Save(string path);

        /// <summary>
        ///   Saves the Hidden Markov Classifier to the specified Output Stream
        /// </summary>
        /// 
        /// <param name="stream">The stream to which the classifier is to be serialized.</param>
        /// 
        void Save(Stream stream);

    }

}
