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

namespace ueb01_constructors
{
    class ClassB : ClassA
    {
        public ClassB() : base("B0")
        {
            PrintMessage("B0", 0);
        }

        public ClassB(string msg) : base(msg)
        {
            PrintMessage(msg, 1);
        }

        public ClassB(string msg, int count) : base(msg)
        {
            PrintMessage(msg, count);
        }

        private void PrintMessage(string msg, int count)
        {
            Console.Write("\nB: " + msg);
            for (int i = 0; i < count; i++)
            {
                Console.Write(".");
            }
            Console.Write(" ");
        }
    }
}
