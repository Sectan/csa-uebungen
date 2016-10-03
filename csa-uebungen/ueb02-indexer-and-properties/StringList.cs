/*
 * Copyright (C) 2016 Sectan
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ueb02_indexer_and_properties
{
    class StringList
    {
        private string[] data;

        public int Size
        {
            get { return data.Length; }
            private set { data = new String[value]; }
        }

        public string[] Data
        {
            get { return data; }
        }

        public StringList()
        {
            data = new String[0];
        }

        public string this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }


        static void Main(string[] args)
        {
            StringList sl = new StringList();
            // Int-Property (setzt die Grösse der Liste)
            sl.Size = 5;
            Console.WriteLine("Size: " + sl.Size);
            // Zugriff auf Array über (Array-)Property
            sl.Data[1] = "Some value";
            sl.Data[3] = "Another value";
            foreach (string s in sl.Data)
            {
                Console.WriteLine("entry: " + s);
            }
            Console.WriteLine();
            // Zugriff auf Array über Indexer
            sl[4] = "Something else";
            sl[0] = sl[1] + ", " + sl[3];
            for (int i = 0; i < sl.Size; i++)
            {
                Console.WriteLine("entry[" + i + "]: " + sl[i]);
            }
            Console.Read();

        }
    }
}
