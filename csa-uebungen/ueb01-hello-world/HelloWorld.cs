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

namespace ueb01_hello_world
{
    class HelloWorld
    {
        private void PrintMessage(string msg, bool upperCase)
        {
            if(upperCase)
            {
                msg = msg.ToUpper();
            }
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();

            helloWorld.PrintMessage("Hello World", false);
            helloWorld.PrintMessage("Hello World", true);

            Console.ReadLine();
        }
    }
}
