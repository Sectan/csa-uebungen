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

namespace ueb01_constructors
{
    class Executor
    {
        static void Main(string[] args)
        {
            ClassA A = new ClassA("A");
            ClassB B0 = new ClassB();
            ClassB B1 = new ClassB("B1");
            ClassB B2 = new ClassB("B2", 2);

            ClassA AA = new ClassA("AA");
            ClassA AB = new ClassB("AB");

            Console.ReadLine();
        }
    }
}
